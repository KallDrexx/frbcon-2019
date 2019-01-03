using System;
using System.Collections.Generic;
using System.Linq;
using Frbcon2019.Gameplay;
using Frbcon2019.GumRuntimes;

namespace Frbcon2019.Screens
{
	public partial class MemoryGame
	{
		private readonly List<PlayingCardRuntime> _cards = new List<PlayingCardRuntime>();
		private readonly List<PlayingCardRuntime> _pickedCards = new List<PlayingCardRuntime>();
		private readonly List<PlayingCardRuntime> _cardsTurningBackOver = new List<PlayingCardRuntime>();
		private readonly Dictionary<int, int> _pickedCardValueCount = new Dictionary<int, int>();
		private double _timeSinceFlipBegan;
		private double _timewhenWon;

		void CustomInitialize()
		{
			SetupBoardForCurrentDifficulty();
		}

		void CustomActivity(bool firstTimeCalled)
		{
			if (_timewhenWon > 0 && PauseAdjustedSecondsSince(_timewhenWon) > SecondsToWaitOnceWon)
			{
				TriggerWinCondition();
				return;
			}

			if (_cardsTurningBackOver.Any() &&
			    _timewhenWon == 0 &&
			    PauseAdjustedSecondsSince(_timeSinceFlipBegan) > SecondsUntilCardsTurnBackOver)
			{
				foreach (var card in _cardsTurningBackOver)
				{
					if (!_pickedCards.Contains(card))
					{
						card.IsShown = false;
					}
				}

				_cardsTurningBackOver.Clear();
			}
		}

		void CustomDestroy()
		{
			foreach (var card in _cards)
			{
				card.RemoveFromManagers();
			}
		}

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }

        private void HandleCardClicked(PlayingCardRuntime clickedCard)
        {
	        if (!GameIsActive)
	        {
		        return;
	        }

	        if (_timewhenWon > 0)
	        {
		        // We already won so just wait for timer to run out
		        return;
	        }

	        if (_pickedCards.Contains(clickedCard))
	        {
		        return;
	        }

	        clickedCard.IsShown = true;
	        _pickedCards.Add(clickedCard);
	        _pickedCardValueCount.TryGetValue(clickedCard.Value, out var count);
	        _pickedCardValueCount[clickedCard.Value] = count + 1;

	        if (_pickedCards.Count == 2)
	        {
		        if (_pickedCardValueCount.Any(x => x.Value >= 2))
		        {
			        _timewhenWon = PauseAdjustedCurrentTime;
		        }

		        _pickedCardValueCount.Clear();
		        _cardsTurningBackOver.AddRange(_pickedCards);
		        _pickedCards.Clear();

		        _timeSinceFlipBegan = PauseAdjustedCurrentTime;
	        }
        }

        private void SetupBoardForCurrentDifficulty()
        {
	        switch (CurrentDifficultyFactor)
	        {
		        case DifficultyFactor.Easy:
			        GenerateCards(2, 3, 2);
			        break;

		        case DifficultyFactor.Medium:
			        GenerateCards(3, 4, 3);
			        break;

		        case DifficultyFactor.Hard:
			        GenerateCards(3, 5, 3);
			        break;

		        case DifficultyFactor.ExtraHard:
			        GenerateCards(3, 6, 5);
			        break;
	        }
        }

        private void GenerateCards(int rows, int columns, int totalMatches)
        {
	        var random = new Random();
	        var cardValuesInOrderPicked = new List<int>();
	        var cardValuesPicked = new HashSet<int>();
	        var matchedValues = new HashSet<int>();
	        var expectedCardCount = rows * columns;

	        // Generate card values, making sure we only have `totalMatches` number of matches
	        var previousValue = 0;
	        while (true)
	        {
		        var nextValue = random.Next(1, 14);
		        if (nextValue == previousValue)
		        {
			        continue;
		        }

		        if (cardValuesPicked.Contains(nextValue))
		        {
			        // We don't want 3 of a kind or too many matches
			        if (!matchedValues.Contains(nextValue) && matchedValues.Count < totalMatches)
			        {
				        matchedValues.Add(nextValue);
				        cardValuesInOrderPicked.Add(nextValue);
			        }
		        }
		        else
		        {
			        cardValuesPicked.Add(nextValue);
			        cardValuesInOrderPicked.Add(nextValue);
		        }

		        previousValue = nextValue;

		        if (cardValuesInOrderPicked.Count >= expectedCardCount && matchedValues.Count == totalMatches)
		        {
			        // If we have picked too many cards to get the correct number of matches, remove
			        // unmatched extra values that were picked
			        while (cardValuesInOrderPicked.Count > expectedCardCount)
			        {
				        for (int i = 0; i < cardValuesInOrderPicked.Count; i++)
				        {
					        if (!matchedValues.Contains(cardValuesInOrderPicked[i]))
					        {
						        cardValuesInOrderPicked.RemoveAt(i);
						        break;
					        }
				        }
			        }

			        break;
		        }
	        }

	        var cardValueIndex = 0;
	        for (var row = 0; row < rows; row++)
	        for (var column = 0; column < columns; column++)
	        {
		        var card = new PlayingCardRuntime
		        {
			        IsShown = false,
			        Value = cardValuesInOrderPicked[cardValueIndex],
			        Suit = (Suit) random.Next(1, 5),
		        };

		        card.X = 50 + (card.GetAbsoluteWidth() + 10) * column;
		        card.Y = 50 +(card.GetAbsoluteHeight() + 10) * row;
		        card.Click += x => HandleCardClicked((PlayingCardRuntime) x);

		        card.AddToManagers();
		        _cards.Add(card);
		        cardValueIndex++;
	        }
        }
	}
}

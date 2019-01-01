using System;
using System.Collections.Generic;
using Frbcon2019.Gameplay;
using Frbcon2019.GumRuntimes;

namespace Frbcon2019.Screens
{
	public partial class MemoryGame
	{
		private readonly List<PlayingCardRuntime> _cards = new List<PlayingCardRuntime>();

		void CustomInitialize()
		{
			const int cardsPerRow = 4;
			const int rows = 3;

			var random = new Random();

			for (var row = 0; row < rows; row++)
			for (var column = 0; column < cardsPerRow; column++)
			{
				var card = new PlayingCardRuntime
				{
					IsShown = false,
					Value = random.Next(1, 13),
					Suit = (Suit) random.Next(1, 4),
				};

				card.X = 50 + (card.GetAbsoluteWidth() + 10) * column;
				card.Y = 50 +(card.GetAbsoluteHeight() + 10) * row;
				card.Click += x => HandleCardClicked((PlayingCardRuntime) x);

				card.AddToManagers();
				_cards.Add(card);
			}
		}

		void CustomActivity(bool firstTimeCalled)
		{
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
	        clickedCard.IsShown = !clickedCard.IsShown;
        }
	}
}

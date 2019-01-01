using System;
using Frbcon2019.Gameplay;

namespace Frbcon2019.GumRuntimes
{
    public partial class PlayingCardRuntime
    {
        private int _value = 1;
        private Suit _suit = Suit.Hearts;
        private bool _isShown;

        public Suit Suit
        {
            get => _suit;
            set
            {
                _suit = value;
                UpdateCardDisplay();
            }
        }

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                UpdateCardDisplay();
            }
        }

        public bool IsShown
        {
            get => _isShown;
            set
            {
                _isShown = value;
                UpdateCardDisplay();
            }
        }

        partial void CustomInitialize()
        {
        }

        private void UpdateCardDisplay()
        {
            if (_isShown)
            {
                CardFront.Visible = true;
                CardBack.Visible = false;

                CardFrontTextureLeft = CalculateTextureLeft();
                CardFrontTextureTop = CalculateTextureTop();
            }
            else
            {
                CardFront.Visible = false;
                CardBack.Visible = true;
            }
        }

        private int CalculateTextureTop()
        {
            const int textureHeight = 558;
            const int cardHeight = textureHeight / 4;

            switch (_suit)
            {
                case Suit.Clubs: return 0;
                case Suit.Diamonds: return cardHeight * 1;
                case Suit.Hearts: return cardHeight * 2;
                case Suit.Spades: return cardHeight * 3;
                default:
                    throw new NotSupportedException($"Suit {_suit} is not supported");
            }
        }

        private int CalculateTextureLeft()
        {
            const int textureWidth = 1300;
            const int cardWidth = textureWidth / 13;

            if (_value > 13 || _value <= 0)
            {
                throw new NotSupportedException("Card values must be between 1 and 13");
            }

            return (_value - 1) * cardWidth;
        }
    }
}

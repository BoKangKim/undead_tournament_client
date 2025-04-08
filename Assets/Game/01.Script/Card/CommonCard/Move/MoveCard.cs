using System.Collections;
using System.Collections.Generic;
using Game.Player;
using UnityEngine;

namespace Game.Card
{
    public enum MoveType
    {
        Right,
        Left,
        Up,
        Down,
        DoubleRight,
        DoubleLeft,
    }

    public abstract class MoveCard : CardBase
    {
        protected MoveType moveType;

        public override void Generate()
        {
            cardPath = CardPath.Common;
            cost = 0;
        }

        public override void Activate(PlayerController owner, Unit unit)
        {
            switch (moveType)
            {
                case MoveType.Right:
                    break;
                case MoveType.Left:
                    break;
                case MoveType.Up:
                    break;
                case MoveType.Down:
                    break;
                case MoveType.DoubleRight:
                    break;
                case MoveType.DoubleLeft:
                    break;
            }
        }
    }
}
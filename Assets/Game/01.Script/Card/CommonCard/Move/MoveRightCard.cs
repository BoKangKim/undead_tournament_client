using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class MoveRightCard : MoveCard
    {
        public override void Generate()
        {
            base.Generate();
            cardName = "MoveRight";
            moveType = MoveType.Right;
        }
    }
}


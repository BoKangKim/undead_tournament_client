using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class MoveDoubleRightCard : MoveCard
    {
        public override void Generate()
        {
            base.Generate();
            cardName = "MoveDoubleRight";
            moveType = MoveType.DoubleRight;
            cost = 1;
        }
    }
}
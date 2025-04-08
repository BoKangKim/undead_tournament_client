using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class MoveDoubleLeftCard : MoveCard
    {
        public override void Generate()
        {
            base.Generate();
            cardName = "MoveDoubleLeft";
            moveType = MoveType.DoubleLeft;
            cost = 1;
        }
    }
}
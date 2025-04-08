using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class MoveUpCard : MoveCard
    {
        public override void Generate()
        {
            base.Generate();
            cardName = "MoveUp";
            moveType = MoveType.Up;
        }
    }
}
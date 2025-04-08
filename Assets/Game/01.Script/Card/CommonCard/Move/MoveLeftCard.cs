using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class MoveLeftCard : MoveCard
    {
        public override void Generate()
        {
            base.Generate();
            cardName = "MoveLeft";
            moveType = MoveType.Left;
        }
    }
}


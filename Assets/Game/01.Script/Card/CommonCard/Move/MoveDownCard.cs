using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class MoveDownCard : MoveCard
    {
        public override void Generate()
        {
            base.Generate();
            cardName = "MoveDown";
            moveType = MoveType.Down;
        }
    }

}

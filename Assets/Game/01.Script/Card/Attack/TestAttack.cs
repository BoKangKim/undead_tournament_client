using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class TestAttack : AttackCard
    {
        public override void Generate()
        {
            cardPath = CardPath.TESTUNIT;
            cardName = "TestCard";
            cost = 1;
            damage = 10;
            arrange = new bool[9];
            arrange[(int)AttackArrange.Right] = true;
        }
    }
}
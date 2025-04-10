using System.Collections;
using System.Collections.Generic;
using Game.Player;
using UnityEngine;

namespace Game.Map
{
    public class Cell : MonoBehaviour
    {
        private (int x, int y) index;
        public (int x, int y) Index => index;

        public void Init(int x, int y)
        {
            this.index.x = x;
            this.index.y = y;
        }
    }
}
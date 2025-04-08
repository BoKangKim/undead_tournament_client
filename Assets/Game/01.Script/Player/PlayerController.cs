using System.Collections;
using System.Collections.Generic;
using Game.Card;
using UnityEngine;

namespace Game.Player
{
    // 유닛 데이터, 카드 데이터 관리
    public class PlayerController : MonoBehaviour
    {
        private Unit unit = null;
        private CardBase[] pickedCards = new CardBase[3];
        private (int x, int y) curCell = (0, 0);

        public void ActiveCard(int index)
        {
            if (index < 0 || index >= pickedCards.Length)
            {
                return;
            }

            pickedCards[index].Activate(this, unit);
        }
    }
}
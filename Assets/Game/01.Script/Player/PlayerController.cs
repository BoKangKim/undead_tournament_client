using System.Collections;
using System.Collections.Generic;
using Game.Card;
using Game.Data;
using UnityEngine;

namespace Game.Player
{
    // 유닛 데이터, 카드 데이터 관리
    public class PlayerController : MonoBehaviour
    {
        // View
        [SerializeField] private Unit unit = null;
        // Data
        private UnitData unitData = null;
        // Card (Logic)
        [SerializeField] private CardBase[] pickedCards; //= new CardBase[3];
        [SerializeField] private int testIndex = 0;

        private (int x, int y) curCell = (0, 1);
        public (int x, int y) CurCell => curCell;

        [ContextMenu("Active")]
        public void TestActive()
        {
            ActiveCard(testIndex);
        }

        public void ActiveCard(int index)
        {
            if (index < 0 || index >= pickedCards.Length)
            {
                return;
            }

            pickedCards[index].Activate(this, unit);
        }

        public void ChangeCell(int x, int y)
        {
            this.curCell.x = x;
            this.curCell.y = y;
        }
    }
}
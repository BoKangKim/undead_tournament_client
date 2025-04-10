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
        // TODO : TEST로 SerializeField로 넣어놓았지만 나중에 지우기
        [SerializeField] private bool isMine;
        [SerializeField] private PlayerController enemy = null;
        public PlayerController Enemy => enemy;
        // View
        [SerializeField] private Unit unit = null;
        // Data
        [SerializeField] private UnitData unitData = null;
        // Card (Logic)
        [SerializeField] private CardBase[] pickedCards; //= new CardBase[3];
        [SerializeField] private int testIndex = 0;

        private (int x, int y) curCell = (0, 1);
        public (int x, int y) CurCell => curCell;

        // TODO : 유닛 스크립터블 오브젝트 받아와서 초기화로 변경 
        private void Awake()
        {
            unitData = new UnitData(100, 100);

            if (!isMine)
            {
                curCell = (3, 1);
            }
        }

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

        public void OnUseMana(int amount)
        {
            unitData.UseMana(amount);
        }

        public void OnDamage(int amount)
        {
            bool isDeath = unitData.Damage(amount);

            if (isDeath)
            {
                unit.OnDeath();
            }
            else
            {
                unit.OnDamage();
            }
        }
    }
}
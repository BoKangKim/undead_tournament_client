using System.Collections;
using System.Collections.Generic;
using Game.Player;
using UnityEngine;

namespace Game.Card
{
    public enum MoveType
    {
        Right,
        Left,
        Up,
        Down,
        DoubleRight,
        DoubleLeft,
    }

    public abstract class MoveCard : CardBase
    {
        [SerializeField] protected MoveType moveType;

        public override void Generate()
        {
            cardPath = CardPath.Common;
            cost = 0;
        }

        public override void Activate(PlayerController owner, Unit unit)
        {
            Vector2? targetPos = null;
            (int x, int y) cell = owner.CurCell;

            int unitWidthIndex = cell.x;
            int unitHeightIndex = cell.y;

            switch (moveType)
            {
                case MoveType.Right:
                    unitWidthIndex += 1;
                    break;
                case MoveType.Left:
                    unitWidthIndex -= 1;
                    break;
                case MoveType.Up:
                    unitHeightIndex -= 1;
                    break;
                case MoveType.Down:
                    unitHeightIndex += 1;
                    break;
                case MoveType.DoubleRight:
                    unitWidthIndex += 2;
                    break;
                case MoveType.DoubleLeft:
                    unitWidthIndex -= 2;
                    break;
            }

            targetPos = ManagerTable.MapManager.GetPositionByIndex(unitWidthIndex, unitHeightIndex);

            if (targetPos == null)
            {
                return;
            }

            // 지금은 바로 옮기지만 Unit이 정해지면 러프하게 -> 애니메이션이랑 동기화
            unit.transform.position = (Vector3)targetPos;
            owner.ChangeCell(unitWidthIndex, unitHeightIndex);

            // 유닛의 Viewing 실행
            unit.Move();
        }
    }
}
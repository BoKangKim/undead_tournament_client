using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveType
{
    Right,
    Left,
    Up,
    Down,
    DoubleRight,
    DoubleLeft,
}

public class MoveCard : CardBase
{
    [SerializeField] private MoveType moveType;

    public override void Logic(Unit unit)
    {
        Vector2? targetPos = null;
        int unitWidthIndex = unit.UnitData.CurWidthIndex;
        int unitHeightIndex = unit.UnitData.CurHeightIndex;

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
        unit.Move(unitWidthIndex, unitHeightIndex);
    }

    public override bool CanPick()
    {
        return false;
    }
}

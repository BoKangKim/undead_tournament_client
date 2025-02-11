using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 꼭 필요할까? 고민중
public class PlayerManager : MonoBehaviour
{
    private Unit selectedUnit = null;
    private Unit enemy = null;

    public Unit Enemy => enemy;

    public int remainEnergy => selectedUnit.UnitData.Energy;
    public int remainHealth => selectedUnit.UnitData.Health;

    private void Awake()
    {
        Unit[] units = FindObjectsOfType<Unit>();

        foreach (Unit unit in units)
        {
#if UNITY_EDITOR
            // AI 스크립트 나오면 변경
            if (!unit.IsMine)
            {
                enemy = unit;
            }
#endif
        }
    }

    public void SelectUnit(Unit selectedUnit)
    {
        this.selectedUnit = selectedUnit;
    }
}

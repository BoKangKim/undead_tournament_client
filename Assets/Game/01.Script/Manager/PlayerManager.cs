using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 꼭 필요할까? 고민중
public class PlayerManager : MonoBehaviour
{
    private Unit selectedUnit = null;

    public int remainEnergy => selectedUnit.UnitData.Energy;
    public int remainHealth => selectedUnit.UnitData.Health;

    public void SelectUnit(Unit selectedUnit)
    {
        this.selectedUnit = selectedUnit;
    }
}

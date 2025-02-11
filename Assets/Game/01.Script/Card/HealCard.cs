using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCard : CardBase
{
    public override void Logic(Unit unit)
    {
        LogUtil.Log($"Heal");
    }

    public override bool CanPick()
    {
        return false;
    }
}

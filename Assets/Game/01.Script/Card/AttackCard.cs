using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCard : CardBase
{
    public override void Logic(Unit unit)
    {
        LogUtil.Log($"Attack");
    }
}

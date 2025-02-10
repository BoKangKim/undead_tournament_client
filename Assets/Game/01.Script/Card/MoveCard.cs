using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCard : CardBase
{
    public override void Logic(Unit unit)
    {
        LogUtil.Log($"Move");
    }
}

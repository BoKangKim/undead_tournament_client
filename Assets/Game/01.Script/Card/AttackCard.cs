using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCard : CardBase
{
    public override void Logic(Unit unit)
    {
        Unit enemy = ManagerTable.PlayerManager.Enemy;

        // Arrange Check
        // 적이 해당 Index에 있는지?
        // OnDamage
        enemy.Damage(data.Damage);
    }

    public override bool CanPick()
    {
        return false;
    }
}

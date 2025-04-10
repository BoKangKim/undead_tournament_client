using System.Collections;
using System.Collections.Generic;
using Game.Player;
using UnityEngine;

namespace Game.Card
{
    public enum AttackArrange
    {
        LeftTop = 0,
        Top,
        RightTop,
        Left,
        Center,
        Right,
        LeftBottom,
        Bottom,
        RightBottom
    }

    public abstract class AttackCard : CardBase
    {
        [SerializeField] protected bool[] arrange;
        [SerializeField] protected int damage;

        public override void Activate(PlayerController owner, Unit unit)
        {
            for (int i = 0; i < arrange.Length; i++)
            {
                if (arrange[i])
                {
                    Attack(owner, i);
                }
            }
        }

        private void Attack(PlayerController owner, int index)
        {
            (int x, int y) owenrIndex = owner.CurCell;
            int width = owenrIndex.x;
            int height = owenrIndex.y;

            switch ((AttackArrange)index)
            {
                case AttackArrange.LeftTop:
                    width -= 1;
                    height -= 1;
                    break;
                case AttackArrange.Top:
                    height -= 1;
                    break;
                case AttackArrange.RightTop:
                    width += 1;
                    height -= 1;
                    break;
                case AttackArrange.Left:
                    width -= 1;
                    break;
                case AttackArrange.Center:
                    break;
                case AttackArrange.Right:
                    width += 1;
                    break;
                case AttackArrange.LeftBottom:
                    width -= 1;
                    height += 1;
                    break;
                case AttackArrange.Bottom:
                    height += 1;
                    break;
                case AttackArrange.RightBottom:
                    width += 1;
                    height += 1;
                    break;
            }

            if (owner.Enemy.CurCell.x == width && owner.Enemy.CurCell.y == height)
            {
                owner.Enemy.OnDamage(damage);
            }
        }
    }
}
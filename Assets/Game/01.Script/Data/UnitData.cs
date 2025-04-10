using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Data
{
    [Serializable]
    public class UnitData
    {
        [SerializeField] private int hp;
        [SerializeField] private int mana;

        public int HP => hp;
        public int Mana => mana;

        public UnitData(int hp, int mana)
        {
            this.hp = hp;
            this.mana = mana;
        }

        public bool Damage(int amount)
        {
            bool isDeath = false;
            hp -= amount;

            if (hp <= 0)
            {
                isDeath = true;
            }

            return isDeath;
        }

        public void UseMana(int amount)
        {
            this.mana -= amount;
        }
    }
}
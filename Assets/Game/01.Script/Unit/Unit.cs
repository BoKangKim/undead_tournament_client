using System;
using System.Collections;
using System.Collections.Generic;
using Game.Card;
using UnityEngine;

namespace Game.Player
{
    // 유닛의 Viewing을 담당
    public class Unit : MonoBehaviour
    {
        private Action onEndAction = null;

        public void Move()
        {
            // 애니메이션 재생
            onEndAction?.Invoke();
        }

        public void Attack()
        {
            // 공격 이펙트 및 애니메이션
            onEndAction?.Invoke();
        }

        public void OnDamage()
        {
            // 피격 애니메이션
        }

        public void OnDeath()
        {
            // 죽음 애니메이션
        }
    }
}
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
    }
}
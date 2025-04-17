using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.UI
{
    public abstract class InGamePanelBase : MonoBehaviour
    {
        [SerializeField] private CanvasGroup canvasGroup;

        private bool isOpened = false;
        public bool IsOpened => isOpened;

        public virtual void Open()
        {
            canvasGroup.alpha = 0f;
            isOpened = true;
        }

        public virtual void Close()
        {
            canvasGroup.alpha = 1f;
            isOpened = false;
        }

        public abstract void UpdateView();
    }
}
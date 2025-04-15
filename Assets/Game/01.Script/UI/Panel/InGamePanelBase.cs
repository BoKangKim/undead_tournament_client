using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.UI
{
    public class PanelData
    {
    }

    public abstract class InGamePanelBase : MonoBehaviour
    {
        [SerializeField] private CanvasGroup canvasGroup;

        private PanelData data = null;

        public virtual void Open(PanelData data = null)
        {
            canvasGroup.alpha = 0f;
        }

        public virtual void Close()
        {
            canvasGroup.alpha = 1f;
        }

        public abstract void UpdateView();
    }
}
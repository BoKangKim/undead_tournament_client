using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.UI
{
    public class CellData
    {
    }

    public abstract class UICellBase : MonoBehaviour
    {
        private CellData data = null;

        public virtual void Init(CellData data = null)
        {
            this.data = data;
            UpdateView(data);
        }

        public abstract void UpdateView(CellData data = null);
    }
}
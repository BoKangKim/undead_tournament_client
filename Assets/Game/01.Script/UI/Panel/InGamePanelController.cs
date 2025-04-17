using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.UI
{
    public class InGamePanelController : MonoBehaviour
    {
        private List<InGamePanelBase> panelList = new List<InGamePanelBase>();
        private InGamePanelBase curOpenedPanel = null;

        private void Awake()
        {
            var panelArr = GetComponentsInChildren<InGamePanelBase>(true);

            foreach (var panel in panelArr)
            {
                panel.Close();
                panelList.Add(panel);
            }
        }

        public T Open<T>() where T : InGamePanelBase
        {
            InGamePanelBase targetPanel = null;

            foreach (var panel in panelList)
            {
                if (panel is T)
                {
                    targetPanel = panel;
                    break;
                }
            }

            if (curOpenedPanel != null)
            {
                curOpenedPanel.Close();
            }

            targetPanel.Open();
            curOpenedPanel = targetPanel;

            return targetPanel as T;
        }

        public void Close()
        {
            if (curOpenedPanel == null)
            {
                return;
            }

            curOpenedPanel.Close();
            curOpenedPanel = null;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.UI
{
    public class CharacterSelectPanel : InGamePanelBase
    {
        [SerializeField] private Transform layout1;
        [SerializeField] private Transform layout2;
        [SerializeField] private CharacterCell cell;

        private CharacterCell[] cellArray = new CharacterCell[8];

        private void Awake()
        {
            for (int i = 0; i < cellArray.Length; i++)
            {
                CharacterCell characterCell = Instantiate<CharacterCell>(cell, Vector3.zero, Quaternion.identity, i < 4 ? layout1 : layout2);
                cellArray[i] = characterCell;
            }
        }

        public override void UpdateView()
        {
        }
    }
}

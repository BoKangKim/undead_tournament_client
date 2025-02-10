using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Data를 꼭 여기서 가지고 있어야 할까?
public class UnitData
{
    [SerializeField] private int health;
    [SerializeField] private int energy;
    private int curWidthIndex = 0;
    private int curHeightIndex = 0;

    public int Health => health;
    public int Energy => energy;
}

// 애니메이션, 포지션 등을 위해서 필요한 스크립트라고 판단됨
public class Unit : MonoBehaviour
{
    private CardBase[] selectedCard = new CardBase[3];
    private UnitData unitData;
    public UnitData UnitData => unitData;

    public void PlayTurn(int index)
    {
        if (index < 0 || index >= selectedCard.Length)
        {
            LogUtil.LogError($"Index Out Of Range in SelectedCard Array : {index}");
            return;
        }

        selectedCard[index].Logic(this);
    }

    public void ClearCard()
    {
        for (int i = 0; i < selectedCard.Length; i++)
        {
            selectedCard[i] = null;
        }
    }
}
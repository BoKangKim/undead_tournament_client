using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Data를 꼭 여기서 가지고 있어야 할까?
[Serializable]
public class UnitData
{
    [SerializeField] private int health;
    [SerializeField] private int energy;
    [SerializeField] private int curWidthIndex = 0;
    [SerializeField] private int curHeightIndex = 0;

    private int maxHealth = 100;

    public int CurWidthIndex => curWidthIndex;
    public int CurHeightIndex => curHeightIndex;

    public int Health => health;
    public int Energy => energy;

    public void SetIndex(int x, int y)
    {
        this.curWidthIndex = x;
        this.curHeightIndex = y;
    }

    public void SetHealth(int health)
    {
        if (health >= maxHealth)
        {
            health = maxHealth;
        }

        this.health = health;
    }
}

// 애니메이션, 포지션 등을 위해서 필요한 스크립트라고 판단됨
public class Unit : MonoBehaviour
{
    [SerializeField] private CardBase[] selectedCard = new CardBase[3];
    [SerializeField] private UnitData unitData;
    public UnitData UnitData => unitData;

    #region TEST CODE
    [SerializeField] private int playIndex;

#if UNITY_EDITOR
    [ContextMenu("PLAY")]
    private void Play()
    {
        PlayTurn(playIndex);
    }
#endif
    #endregion

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

    public void Move(int x, int y)
    {
        unitData.SetIndex(x, y);
    }

    public void Heal(int healAmount)
    {
        int health = unitData.Health + healAmount;
        unitData.SetHealth(health);
    }
}
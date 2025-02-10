using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CardType
{
    Standard,
    // 영웅 이름 추가
}

[Serializable]
public class CardData
{
    // 나중에 데이터 정리 되면 SerializeField 빼고 Init 함수로 넣기
    [SerializeField] private CardType cardType;
    [SerializeField] private string name;
    [SerializeField] private int damage;
    [SerializeField] private int energy;
    private bool[,] arrange = new bool[3, 3];

    public string Name => name;
    public int Damage => damage;
    public int Energy => energy;

    public virtual void Parse(string json)
    {
        // type + name 으로 해당 카드 스프라이트, 이펙트 찾기
    }
}

public abstract class CardBase : MonoBehaviour
{
    [SerializeField] private Image img;
    [SerializeField] private Button cardButton;
    [SerializeField] private CardData data = null;

    public abstract void Logic(Unit unit);

    public virtual void ViewUpdate()
    {
        if (ManagerTable.PlayerManager.remainEnergy < data.Energy)
        {
            // Cant Pick UI Update
        }
    }

    public virtual void Init(string json)
    {
        data = new CardData();
        data.Parse(json);
    }
}

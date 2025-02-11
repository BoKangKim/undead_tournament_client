using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    private List<CardBase> pickedCardList = new List<CardBase>();
    private List<CardBase> canPickCardList = new List<CardBase>();

    public CardBase[] RandomPickCard()
    {
        // canPickCardList에서 5개 랜덤 뽑기
        return new CardBase[5];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTable : MonoBehaviour
{
    public static PlayerManager PlayerManager
    {
        get
        {
            if (playerManager == null)
            {
                playerManager = FindObjectOfType<PlayerManager>();
            }

            return playerManager;
        }
    }

    public static CardManager CardManager
    {
        get
        {
            if (cardManager == null)
            {
                cardManager = FindObjectOfType<CardManager>();
            }

            return cardManager;
        }
    }
    private static PlayerManager playerManager;
    private static CardManager cardManager;
}

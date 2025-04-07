using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTable : MonoBehaviour
{
    public static MapManager MapManager
    {
        get
        {
            if (mapManager == null)
            {
                mapManager = FindObjectOfType<MapManager>();
            }

            return mapManager;
        }
    }

    private static MapManager mapManager;
}

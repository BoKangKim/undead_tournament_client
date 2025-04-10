using System.Collections;
using System.Collections.Generic;
using Game.Map;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] private bool convertOnAwake = true;
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private Cell[] cellArray;

    private Cell[,] resultCellArray = null;

    private void Awake()
    {
        if (convertOnAwake)
        {
            Util.ConvertToTwoDimensionalArray<Cell>(width, height, cellArray, out resultCellArray);

            for (int y = 0; y < resultCellArray.GetLength(0); y++)
            {
                for (int x = 0; x < resultCellArray.GetLength(1); x++)
                {
                    resultCellArray[y, x].Init(x, y);
                }
            }
        }
    }

    private bool ValidateArray(int x, int y)
    {
        if (resultCellArray == null)
        {
            return false;
        }

        if (x >= width || y >= height || x < 0 || y < 0)
        {
            return false;
        }

        return true;
    }

    public Vector2? GetPositionByIndex(int x, int y)
    {
        if (!ValidateArray(x, y))
        {
            LogUtil.LogError($"Unable Index ({x},{y}) , Max Index : ({width - 1}, {height - 1})");
            return null;
        }

        return resultCellArray[y, x].transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] private bool convertOnAwake = true;
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private Transform[] cellArray;

    private Transform[,] resultCellArray = null;

    private void Awake()
    {
        if (convertOnAwake)
        {
            Util.ConvertToTwoDimensionalArray<Transform>(width, height, cellArray, out resultCellArray);
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

        return resultCellArray[y, x].position;
    }
}

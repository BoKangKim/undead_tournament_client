using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    public static bool ConvertToTwoDimensionalArray<T>(int width, int height, T[] prevArray, out T[,] resultArray)
    {
        resultArray = null;

        if (!ValidateArray<T>(width, height, prevArray))
        {
            return false;
        }

        int index = 0;
        resultArray = new T[height, width];

        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                resultArray[h, w] = prevArray[index];

                index++;
            }
        }

        return true;
    }

    private static bool ValidateArray<T>(int width, int height, T[] array)
    {
        int targetLength = width * height;

        return targetLength == array.Length;
    }
}

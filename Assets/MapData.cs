using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{
    int width = 10, height = 5;
    private void Start()
    {
        MakeMyMap();
    }
    int[,] MakeMyMap()
    {
        int[,] map = new int[height, width];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                map[j, i] = 0;
                Debug.Log(map[i, j]);
            }
        }
        map[1, 0] = 1;
        map[1, 1] = 1;
        map[1, 2] = 1;
        map[3, 2] = 1;
        map[3, 3] = 1;
        map[3, 4] = 1;
        map[4, 2] = 1;
        map[5, 1] = 1;
        map[5, 2] = 1;
        map[6, 2] = 1;
        map[6, 3] = 1;
        map[8, 1] = 1;
        map[8, 4] = 1;

        return map;
    }

}

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HexGridData", menuName = "HexGrid/Data", order = 1)]
public class HexGridData : ScriptableObject
{
    public int width;
    public int height;
    public float cellSize;

    public GameObject emptyHexPrefab;
    public GameObject landHexPrefab;
    public GameObject waterHexPrefab;
    public GameObject castlePrefab;
    public GameObject mountainPrefab;

    public List< HexCellType> cellTypes;
}

[System.Serializable]
public class HexCellType
{



    public int xCordinate;
    public int zCordinate;
    public int value;
}



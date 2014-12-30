using System;
using UnityEngine;

public class HexGrid2 : MonoBehaviour
{
    public HexGridData gridData;
    public Transform mapParentTransform;



    private void Start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {

        // gridData hexCellType add

        /*      gridData.cellTypes.Clear();
             for (int x = 0; x < gridData.width; x++)
             {
                 for (int z = 0; z < gridData.height; z++)
                 {
                     gridData.cellTypes.Add(new HexCellType { xCordinate = x, zCordinate = z, value = UnityEngine.Random.Range(0, 4) });

                 }
             } */

        // Kameranın konumu
        Vector3 cameraPosition = new Vector3((gridData.width * (gridData.cellSize * Mathf.Sqrt(3)) - gridData.cellSize * Mathf.Sqrt(3) / 2) / 2, Camera.main.transform.position.y, Camera.main.transform.position.z);

        // Kamerayı grid'in x ekseninin tam ortasına yerleştir
        Camera.main.transform.position = cameraPosition;


        // camera orta noktası center

        for (int x = 0; x < gridData.width; x++)
        {
            for (int z = 0; z < gridData.height; z++)
            {

                int cellIndex = z * gridData.width + x;
                Vector3 position = CalculateHexPosition(x, z, gridData.cellSize);


                GameObject obj = Instantiate(GetPrefab(cellIndex), position, Quaternion.Euler(0, 0, 0));


                Debug.Log("Hexagon oluşturuldu: " + x + " X " + z + " index= " + cellIndex + " position=" + position + " position=" + obj.transform.position);
                obj.gameObject.name = "Hex_" + x + "_" + z + "_index= " + cellIndex;
                obj.transform.parent = mapParentTransform;



            }

        }
    }

    private GameObject GetPrefab(int cellIndex)
    {

        HexCellType cellType = gridData.cellTypes[cellIndex];
        switch (cellType.value)
        {
            case 0:
                return gridData.emptyHexPrefab;
            case 1:
                return gridData.landHexPrefab;
            case 2:
                return gridData.waterHexPrefab;
            case 3:
                return gridData.castlePrefab;
            case 4:
                return gridData.mountainPrefab;
            default:
                return gridData.emptyHexPrefab;
        }


    }

    Vector3 CalculateHexPosition(int x, int z, float cellSize)
    {
        Vector3 position = new Vector3(0, 0, 0);
        position.x = x * (cellSize * Mathf.Sqrt(3));
        position.z = z * (cellSize * 1.5f);

        if (z % 2 != 0)
        {
            //! tek ise
            position.x += cellSize * Mathf.Sqrt(3) / 2;
        }




        return new Vector3(position.x, 0f, position.z);
    }


}

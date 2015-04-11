using UnityEngine;

public class HexSelector : MonoBehaviour
{

    private GameObject lastGrid;

    void Update()
    {   //! Dokunma başladı
        if (Input.touchCount > 0)
        {
            // Dokunulan hex'i seç
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                //! önceki gridi eski haline çevir
                if (lastGrid != null)
                {
                    lastGrid.GetComponent<MeshRenderer>().material.color = default(Color);
                }

                lastGrid = hit.collider.gameObject;
                lastGrid.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }




    }
}

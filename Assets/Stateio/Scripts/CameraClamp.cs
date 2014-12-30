using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //kamera z ekseninde sadece 3 ile 9 arasında hareket edebilir
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, 3, 9)
         );
    }
}

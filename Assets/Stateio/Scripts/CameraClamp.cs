using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{

    [SerializeField] public float minClamp = 3;
    [SerializeField] public float maxClamp = 10;

    // Update is called once per frame
    void Update()
    {
        //kamera z ekseninde sadece 3 ile 10 arasında hareket edebilir
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, minClamp, maxClamp)
         );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotLine : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public LineRenderer lineRenderer;
    public float textureSpeed = 2.0f;

    private void Update()
    {
        if (lineRenderer == null || startPoint == null || endPoint == null)
            return;

        // Çizgi konumlarını güncelle
        lineRenderer.SetPosition(0, startPoint.position);
        lineRenderer.SetPosition(1, endPoint.position);

        // Doku hareketini animasyonla
        float offset = Time.time * textureSpeed % 1;
        lineRenderer.material.mainTextureOffset = new Vector2(offset, 0);


    }
}

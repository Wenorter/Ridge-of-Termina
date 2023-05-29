using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    void Update()
    {
        Vector3 original_pos = transform.localPosition;
        float x = Random.Range(-1f, 1f) * 10f;
        float y = Random.Range(-1f, 1f) * 10f;

        transform.localPosition = new Vector3(x, y, original_pos.z);
    }
        
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ObjectFocused;

    private void Update()
    {
        Vector3 pos  = ObjectFocused.transform.position ;
        pos.z = transform.position.z;
        
        transform.position = pos; 

    }
}

﻿using System.Collections;
using System.Collections.Generic;
 using UnityEditor;
 using UnityEngine;

 [ExecuteAlways]
 public class MaskMesh : MonoBehaviour
{
    public Material mask;

    private static readonly int LightPosition = Shader.PropertyToID("_LightPosition");

    // Start is called before the first frame update
    private void LateUpdate(){
        mask.SetVector(LightPosition,transform.position);
    }
}

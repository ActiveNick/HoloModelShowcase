using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.SpatialMapping;

public class SpatialController : MonoBehaviour {

    // Use this for initialization
    SpatialMappingManager smm;

    // Use this for initialization
    void Start()
    {
        smm = GetComponent<SpatialMappingManager>();
    }

    public void DisplayMesh()
    {
        smm.DrawVisualMeshes = true;
    }

    public void HideMesh()
    {
        smm.DrawVisualMeshes = false;
    }
}

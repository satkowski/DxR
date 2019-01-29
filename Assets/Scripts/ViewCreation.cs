using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ViewCreation : MonoBehaviour {
    private const string configPath = "scatterplot3D.json";

    // Use this for initialization
    void Start()
    {
        DxR.Vis newVis = DxR.Vis.Create(configPath, false);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}

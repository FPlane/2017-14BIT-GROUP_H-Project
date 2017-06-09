using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomResolution : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.fullScreen = !Screen.fullScreen;
        Screen.SetResolution(480, 800, false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

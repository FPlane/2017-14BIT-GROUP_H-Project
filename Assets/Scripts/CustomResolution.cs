using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomResolution : MonoBehaviour {

    [SerializeField]
    private int screenHeight = 800;

    [SerializeField]
    private int screenWidth = 400;

	// Use this for initialization
	void Start () {
        Screen.fullScreen = !Screen.fullScreen;
        Screen.SetResolution(screenWidth, screenHeight, false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

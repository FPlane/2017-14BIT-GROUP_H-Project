using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour {

    public static GameSystem instance;
    bool gameloading;

	// Use this for initialization
	void Awake () {
		if(!gameloading)
        {
            instance = this;
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
            gameloading = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

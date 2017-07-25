using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteMusic : MonoBehaviour {
    public static muteMusic instance;
	// Use this for initialization
	void Start () {
        makeSingleIT();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void makeSingleIT()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}

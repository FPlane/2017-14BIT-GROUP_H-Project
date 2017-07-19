using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class self_destruct_ufo : MonoBehaviour {

    private float time = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, time);
    }
}

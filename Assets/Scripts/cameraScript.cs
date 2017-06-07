using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

    public static float offsetX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (planeScript.instance != null)
        {
            if (planeScript.instance.isAlive)
            {
                moveTheCamera();
            }
        }
	}

    void moveTheCamera()
    {
        Vector3 temp = transform.position;
        temp.x = planeScript.instance.GetPositionX() + offsetX;
        transform.position = temp;
    }
}

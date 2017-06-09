using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

    // Use this for initialization
    public static float offsetX;

	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (planeScript.instance != null)
        {
            if(planeScript.instance.isAlive)
            {
                moveTheCamera();
            }
        }
	}

    // move the camera to the X "from left to right" follow the plane
    void moveTheCamera()
    {
        Vector3 temp = transform.position;
        temp.x = planeScript.instance.GetPositionX() + offsetX;
        transform.position = temp; 
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoXmove : MonoBehaviour {

    // Use this for initialization
    public float speed = 4f;
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        ufoMovement();
        Destroy(gameObject, 4f);
    }

    void ufoMovement()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }
}

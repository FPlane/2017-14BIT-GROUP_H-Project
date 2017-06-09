using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class snaptoGrids : MonoBehaviour {

    public float grid = 0.5f;
    float x = 0f, y = 0f;
	
	// Update is called once per frame
	void Update () {
		if (grid > 0f)
        {
            float new_grid = 1f / grid;

            x = Mathf.Round(transform.position.x * new_grid) / new_grid;
            y = Mathf.Round(transform.position.y * new_grid) / new_grid;

            transform.position = new Vector3(x, y, transform.position.z);
        }
	}
}

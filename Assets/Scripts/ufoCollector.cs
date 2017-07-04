using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoCollector : MonoBehaviour {

    private GameObject[] ufoHolder;
    private float distance = 10f; // doi cho nay cho khop vs distance 
    private float lastUFOx;




    public float ufoMinHeight;
    public float ufoMaxHeight;



    // Use this for initialization
    void Awake() {
        ufoHolder = GameObject.FindGameObjectsWithTag("PipeHolder");

        for (int i = 0; i < ufoHolder.Length; i++)
        {
            Vector3 temp = ufoHolder[i].transform.position;
            temp.y = Random.Range(ufoMinHeight, ufoMaxHeight);
            ufoHolder[i].transform.position = temp;
        }

        lastUFOx = ufoHolder[0].transform.position.x;

        for(int i = 1; i < ufoHolder.Length; i++)
        {
            if(lastUFOx < ufoHolder [i].transform.position.x)
            {
                lastUFOx = ufoHolder[i].transform.position.x;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "PipeHolder")
        {
            Vector3 temp = target.transform.position;
            temp.x = lastUFOx + distance;
            temp.y = Random.Range(ufoMinHeight, ufoMaxHeight);
            target.transform.position = temp;
            lastUFOx = temp.x;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOCollector : MonoBehaviour {

    private GameObject[] ufo;
    private GameObject UFO;

    [SerializeField]
    private int distance;
    private float lastUFOX;
    public float DropMaxHeight;
    public float DropMinHeight;

    void Awake()
    {
        ufo = GameObject.FindGameObjectsWithTag("UFO");
        for (int i = 0; i < ufo.Length; i++)
        {
            Vector3 temp = ufo[i].transform.position;
            temp.y = Random.Range(DropMinHeight, DropMaxHeight);
            ufo[i].transform.position = temp;
        }

        lastUFOX = ufo[0].transform.position.x;

        for (int i = 1; i < ufo.Length; i++)
        {
            if (lastUFOX < ufo[i].transform.position.x)
            {
                lastUFOX = ufo[i].transform.position.x;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "UFO")
        {

            Vector3 temp = target.transform.position;
            temp.x = lastUFOX + distance;
            temp.y = Random.Range(DropMinHeight, DropMaxHeight);
            target.transform.position = temp;
            lastUFOX = temp.x;
        }


    }

    void Update()
    {

    }
}

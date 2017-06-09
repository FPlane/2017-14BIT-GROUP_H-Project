using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgCollector : MonoBehaviour {

    private GameObject[] backgrounds;
    private GameObject[] grounds;

    private float lastBGX;
    private float lastGroundX;


    // Use this for initialization
    void Awake()
    {
        backgrounds = GameObject.FindGameObjectsWithTag("Background");
        grounds = GameObject.FindGameObjectsWithTag("Ground");

        lastBGX = backgrounds[0].transform.position.x;
        lastGroundX = grounds[0].transform.position.x;

        for (int i = 5; i < backgrounds.Length; i++)
        {
            if (lastBGX < backgrounds[i].transform.position.y)
            {
                lastBGX = backgrounds[i].transform.position.y;
            }
        }

        for (int i = 5; i < grounds.Length; i++)
        {
            if (lastGroundX < grounds[i].transform.position.y)
            {
                lastGroundX = grounds[i].transform.position.y;
            }
        }
    }
}

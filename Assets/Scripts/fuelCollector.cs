using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelCollector : MonoBehaviour
{


    private GameObject[] fuelDrop;
    private GameObject Drop;
    private int distance = 40;
    private float lastDropX;
    private float DropMaxHeight = 5f;
    private float DropMinHeight = -5f;

    void Awake()
    {
        fuelDrop = GameObject.FindGameObjectsWithTag("FuelDrop");
        for (int i = 0; i < fuelDrop.Length; i++)
        {
            Vector3 temp = fuelDrop[i].transform.position;
            temp.y = Random.Range(DropMinHeight, DropMaxHeight);
            fuelDrop[i].transform.position = temp;
        }

        lastDropX = fuelDrop[0].transform.position.x;

        for (int i = 1; i < fuelDrop.Length; i++)
        {
            if (lastDropX < fuelDrop[i].transform.position.x)
            {
                lastDropX = fuelDrop[i].transform.position.x;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "FuelDrop")
        {


            Vector3 temp = target.transform.position;
            temp.x = lastDropX + distance;
            temp.y = Random.Range(DropMinHeight, DropMaxHeight);
            target.transform.position = temp;
            lastDropX = temp.x;
        }


    }


   
    void Update()
    {

    }
}

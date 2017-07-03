using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerCollector : MonoBehaviour
{

    private GameObject[] tower;
    private GameObject Tower;
    private int distance = 10;
    private float lastTowerX;
    //private float DropMaxHeight = 5f;
    //private float DropMinHeight = -5f;

    void Awake()
    {
       tower = GameObject.FindGameObjectsWithTag("PipeHolder");//Pipe?
       for (int i = 0; i < tower.Length; i++)
       {
               Vector3 temp = tower[i].transform.position;
               //temp.y = Random.Range(DropMinHeight, DropMaxHeight);
               tower[i].transform.position = temp;
       }

       lastTowerX = tower[0].transform.position.x;

       for (int i = 1; i < tower.Length; i++)
       {
            if (lastTowerX < tower[i].transform.position.x)
            {
                lastTowerX = tower[i].transform.position.x;
            }
       }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "PipeHolder")
        {
            Time.timeScale = 0.0f;
            Vector3 temp = target.transform.position;
            temp.x = lastTowerX + distance;
            //temp.y = Random.Range(DropMinHeight, DropMaxHeight);
            target.transform.position = temp;
            lastTowerX = temp.x;
        }


    }

    void Update()
    {

    }
}
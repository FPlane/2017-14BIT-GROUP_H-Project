using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerCollector : MonoBehaviour
{

    private GameObject[] tower;
    private GameObject Tower;

    [SerializeField]
    private int distance; // go ben unity ay
    private float lastTowerX;
    public float DropMaxHeight;
    public float DropMinHeight;

    void Awake()
    {
        tower = GameObject.FindGameObjectsWithTag("PipeHolder");
        for (int i = 0; i < tower.Length; i++)
        {
            Vector3 temp = tower[i].transform.position;
            temp.y = Random.Range(DropMinHeight, DropMaxHeight);
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
<<<<<<< HEAD
            Time.timeScale = 0.0f;
=======
      
>>>>>>> c1a7651d71613429ce961fd461c54ba5e5fc4673
            Vector3 temp = target.transform.position;
            temp.x = lastTowerX + distance;
            temp.y = Random.Range(DropMinHeight, DropMaxHeight);
            target.transform.position = temp;
            lastTowerX = temp.x;
        }


    }

    void Update()
    {

    }

    //private GameObject[] PipeHolder;
    //private GameObject[] Pipe;

    //private float lastPipeHolderX;
    //private float lastPipeX;


    //// Use this for initialization
    //void Awake()
    //{
    //    PipeHolder = GameObject.FindGameObjectsWithTag("PipeHolder");
    //    Pipe = GameObject.FindGameObjectsWithTag("Pipe");

    //    lastPipeHolderX = PipeHolder[0].transform.position.x;
    //    lastPipeX = Pipe[0].transform.position.x;

    //    for (int i = 1; i < PipeHolder.Length; i++)
    //    {
    //        if (lastPipeHolderX < PipeHolder[i].transform.position.x)
    //        {
    //            lastPipeHolderX = PipeHolder[i].transform.position.x;
    //        }
    //    }

    //    for (int i = 1; i < Pipe.Length; i++)
    //    {
    //        if (lastPipeX < Pipe[i].transform.position.x)
    //        {
    //            lastPipeX = Pipe[i].transform.position.x;
    //        }
    //    }
    //}

    //void OnTriggerEnter2D(Collider2D target)
    //{
    //    if (target.tag == "PipeHolder")
    //    {
    //        Vector3 temp = target.transform.position;
    //        float width = ((BoxCollider2D)target).size.x;
    //        temp.x = lastPipeHolderX + width;
    //        target.transform.position = temp;
    //        lastPipeHolderX = temp.x;
    //    }
    //    else if (target.tag == "Pipe")
    //    {
    //        Vector3 temp = target.transform.position;
    //        float width = ((BoxCollider2D)target).size.x;
    //        temp.x = lastPipeX + width;
    //        target.transform.position = temp;
    //        lastPipeX = temp.x;
    //    }
    //}
}
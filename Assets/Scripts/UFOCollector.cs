using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOCollector : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Destroy")
        {
            Destroy(target.gameObject);
           
        }


    }
}

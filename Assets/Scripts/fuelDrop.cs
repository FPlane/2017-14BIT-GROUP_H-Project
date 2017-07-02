using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelDrop : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(gameObject);
          if(gameObject.tag == "FuelDrop")
            {
                GameObject.Find("fuelSlider").GetComponent<fuel>().planeFuel += 2f;
            }
        }
    }


}

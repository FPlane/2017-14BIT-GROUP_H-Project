using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelDrop : MonoBehaviour {

    public float FuelUnit;

    // add 2 fuel unit to the plane
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            //gameObject.GetComponent<Renderer>().enabled = false;
          
            if (gameObject.tag == "FuelDrop")
            {
                GameObject.Find("fuelSlider").GetComponent<fuel>().planeFuel += FuelUnit;
            }
        }
    }
    

}

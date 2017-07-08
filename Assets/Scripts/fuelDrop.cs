using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelDrop : MonoBehaviour {

    private float FuelUnit = 5f;

    // initiation variable once
    void Start()
    {

        bool flag = false;

        // if player's fuel is lower than 5
        // give them second change to continue to play by giving them 30 fuel unit
        // after that fuelunit return to default by setting fuel unit to 5f

        if(fuel.instance.planeFuel <= 5)
        {
            FuelUnit += 30f;
            flag = true;
        }
        if(flag == true)
        {

            FuelUnit += 5f;
        }
    }

    // add 2 fuel unit to the plane
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            //gameObject.GetComponent<Renderer>().enabled = false;
          
            if (gameObject.tag == "Pipe")
            {
                GameObject.Find("fuelSlider").GetComponent<fuel>().planeFuel += FuelUnit;
            }
        }
    }
    

}

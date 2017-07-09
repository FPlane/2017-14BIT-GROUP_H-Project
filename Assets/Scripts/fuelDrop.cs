using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelDrop : MonoBehaviour {

    public static fuelDrop intance;

    private float FuelUnit = 10f;

    public bool flag;

    // initiation variable once

    void Awake()
    {
        //flag = false;
        if (intance == null)
        {
            intance = this;
        }
        print(flag);
    }

    void Update()
    {


        //if player's fuel is lower than 5
        // give them second change to continue to play by giving them 30 fuel unit
        // after that fuelunit return to default by setting fuel unit to 5f

        //if (flag == false)
        //{
        //    if (fuel.instance.planeFuel < 5.0f)
        //    { 
                
        //        flag = true;
        //    }
        //    FuelUnit += 30f;
        //}
        //else if (flag == true)
        //{
        //    FuelUnit += 5f;
        //}


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

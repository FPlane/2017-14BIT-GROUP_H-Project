using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuel : MonoBehaviour {

    public static fuel instance;

    [SerializeField]
    private GameObject fuelDrop;
    

    private Slider slider;
    public float planeFuel = 10f;
    public float fuelBurn = 1f;


    // Use this for initialization
    void Awake()
    {
        getReference();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (planeScript.instance != null)
        { 
            if(planeFuel > 10)
            {
                planeFuel = 10f;
            }
            if (planeFuel > 0)
            {

                planeFuel -= fuelBurn * Time.deltaTime;
                slider.value = planeFuel;
                if(planeScript.instance != null)
                {
                    if(planeScript.instance.didFlap)
                    {
                        planeFuel -= fuelBurn * 0.5f;
                    }
                }
            }
            else
            {
                // plane stop after emptying fuel
                planeScript.instance.isAlive = false;
                
            }
        }
    }

    void getReference()
    {
        slider = GameObject.Find("fuelSlider").GetComponent<Slider>();

        slider.minValue = 0f;
        slider.maxValue = planeFuel;
        slider.value = slider.maxValue;
    }


}

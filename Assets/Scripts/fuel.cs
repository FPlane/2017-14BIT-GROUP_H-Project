using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuel : MonoBehaviour
{

    public static fuel instance;

    [SerializeField]
    private GameObject fuelDrop;


    private Slider slider;
    public float planeFuel = 20f;
    public float fuelBurn = 1f;


    // Use this for initialization
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        getReference();

    }

    // Update is called once per frame
    void Update()
    {
        if (planeScript.instance != null)
        {
            if (planeFuel > 20f)
            {
                planeFuel = 20f;
            }
            else if (planeFuel > 0)
            {

                planeFuel -= fuelBurn * Time.deltaTime;
                slider.value = planeFuel;
                
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

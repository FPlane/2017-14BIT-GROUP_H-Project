using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuel : MonoBehaviour
{

    public static fuel instance;

    [SerializeField]
    private GameObject fuelDrop;

    public GameObject[] fuelDropUI;


    private Slider slider;
    public float maxFuel;
    public float planeFuel;
    public float fuelBurn;

    public Text BestDistanceText;

    //public SpriteRenderer rend;

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
            if (planeFuel > maxFuel)
            {
                planeFuel = maxFuel;
            }
            else if (planeFuel > 0)
            {

                planeFuel -= fuelBurn * Time.deltaTime;
                slider.value = planeFuel;
                

            }
            else
            {
                // IMPORTANT !!! 
                // uncommnent this when release 
                // plane stop after emptying fuel 
                // planeScript.instance.isAlive = false;
                Time.timeScale = 0;
                if(planeScript.instance != null)
                {
                    int distance = planeScript.instance.distance;
                    GameOver(distance);
                }
                //if plane crash, stop game, hide pause button & show gameoverPanel
                

            }
        }
    }

    public void GameOver(int distance)
    {
        if (gamePlayMananger.instance != null)
        {
            gamePlayMananger.instance.hidePauseButton();
            gamePlayMananger.instance.showGameOverPanel(distance);
        }

        if (distance > GameManager.instance.getHighScore())
        {

            GameManager.instance.setHighScore(distance);
        }
        BestDistanceText.text = GameManager.instance.getHighScore().ToString("F0") + " m";
    }

    void getReference()
    {
        slider = GameObject.Find("fuelSlider").GetComponent<Slider>();

        slider.minValue = 0f;
        slider.maxValue = planeFuel;
        slider.value = slider.maxValue;
    }


}

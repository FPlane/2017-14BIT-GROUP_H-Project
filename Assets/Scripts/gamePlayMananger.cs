using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamePlayMananger : MonoBehaviour {

    public static gamePlayMananger instance;

    [SerializeField]
    private Button GuideButton;

    [SerializeField]
    private Text PauseUI;

    [SerializeField]
    private Text DistanceUI;

    [SerializeField]
    private Text GameOverUI;

    [SerializeField]
    private GameObject FuelDropUI;

    [SerializeField]
    private Slider FuelSliderUI;

    [SerializeField]
    private GameObject gameOverPanel;

    public Button resetButton;
    public Button pauseButton;
    public Button resumeButton;
    public Button ExitGame;


    public Text LastDistanceText;
    public Text BestDistanceText;

   

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

 
        //pauseButton.gameObject.SetActive(false);
        //DistanceUI.gameObject.SetActive(false);
        //resetButton.gameObject.SetActive(false);
        //FuelDropUI.gameObject.SetActive(false);
        //FuelSliderUI.gameObject.SetActive(false);

        pauseButton.gameObject.SetActive(true);
        DistanceUI.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(true);
        FuelDropUI.gameObject.SetActive(true);
        FuelSliderUI.gameObject.SetActive(true);
    }

    public void Guide_Button()
    {
        Time.timeScale = 1;
        GuideButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
        DistanceUI.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(true);
        FuelDropUI.gameObject.SetActive(true);
        FuelSliderUI.gameObject.SetActive(true);

    }

    public void toTheMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void quitTheGame()
    {
        Application.Quit();
    }


    public void pause_Button(int distance)
    {
        Time.timeScale = 0;
        pauseButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(true);
        gameOverPanel.SetActive(true);
        GameOverUI.gameObject.SetActive(false);
        PauseUI.gameObject.SetActive(true);
        DistanceUI.gameObject.SetActive(false);
        FuelDropUI.gameObject.SetActive(false);
        FuelSliderUI.gameObject.SetActive(false);



        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer)
        {
            ExitGame.gameObject.SetActive(true);
        }
        else if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            ExitGame.gameObject.SetActive(false);
        }

        if (planeScript.instance != null)
        {
            LastDistanceText.text = planeScript.instance.distance.ToString("F0") + " m";
        }

        
        
        BestDistanceText.text = GameManager.instance.getHighScore().ToString("F0") + " m";
    }

    public void resume_Button()
    {
        Time.timeScale = 1;
        resumeButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
        PauseUI.gameObject.SetActive(false);
        gameOverPanel.SetActive(false);
        DistanceUI.gameObject.SetActive(true);
        FuelDropUI.gameObject.SetActive(true);
        FuelSliderUI.gameObject.SetActive(true);
 
    }

    public void reset_Button()
    {
        
        GuideButton.gameObject.SetActive(false);
        SceneManager.LoadScene("gameplay");
    }

    public void hidePauseButton()
    {
        pauseButton.gameObject.SetActive(false);
    }


    public void showGameOverPanel(int distance)
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        DistanceUI.gameObject.SetActive(false);
        FuelDropUI.gameObject.SetActive(false);
        FuelSliderUI.gameObject.SetActive(false);

        GameOverUI.gameObject.SetActive(true);
        PauseUI.gameObject.SetActive(false);


        Destroy(GameObject.Find("FuelDrop"));
        //Destroy(GameObject.Find("FuelDrop(Clone)"));

        
        LastDistanceText.text = distance.ToString("F0") + " m";
        if (distance > GameManager.instance.getHighScore())
        {

            GameManager.instance.setHighScore(distance);
        }
        BestDistanceText.text = GameManager.instance.getHighScore().ToString("F0") + " m";

    }

}

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
    private GameObject FuelDropUI;

    [SerializeField]
    private Slider FuelSliderUI;

    [SerializeField]
    private GameObject gameOverPanel;

    public Button resetButton;
    public Button pauseButton;
    public Button resumeButton;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        //Time.timeScale = 0;
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

    public void pause_Button()
    {
        Time.timeScale = 0;
        pauseButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(true);
        PauseUI.gameObject.SetActive(true);
    }

    public void resume_Button()
    {
        Time.timeScale = 1;
        resumeButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
        PauseUI.gameObject.SetActive(false);
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


    public void showGameOverPanel()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        DistanceUI.gameObject.SetActive(false);
        FuelDropUI.gameObject.SetActive(false);
        FuelSliderUI.gameObject.SetActive(false);
        Destroy(GameObject.Find("FuelDrop"));
        //Destroy(GameObject.Find("FuelDrop(Clone)"));
    }

}

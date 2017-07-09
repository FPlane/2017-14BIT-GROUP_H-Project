using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamePlayMananger : MonoBehaviour {

    [SerializeField]
    private Button GuideButton;

    [SerializeField]
    private Text PauseUI;

    public Button resetButton;
    public Button pauseButton;
    public Button resumeButton;

    void Start()
    {
        
        Time.timeScale = 0;
        pauseButton.gameObject.SetActive(false);

    }

    public void Guide_Button()
    {
        Time.timeScale = 1;
        GuideButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
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

}

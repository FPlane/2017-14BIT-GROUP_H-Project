using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menuController : MonoBehaviour {

    public static menuController instance;

    // GET UI ELEMENT
    public GameObject plane;
    public GameObject QuitButton;
    public GameObject Title;
    public GameObject BackButton;
    public GameObject playmusic;


    public Text QuitText;
    public Text SettingText;

    public void playButton()
    {
        SceneManager.LoadScene(2);
    }

    public void setting_button()
    {
        
    }

    public void exitButton()
    {
        Application.Quit();
    }

    void Awake()
    {

    }

    

    void Start()
    {
        SettingText.GetComponent<Text>().color = Color.red;
        QuitText.GetComponent<Text>().color = Color.red;
        BackButton.gameObject.SetActive(false);
        playmusic.gameObject.SetActive(false);

    }

    public void Quit_game()
    {
        Application.Quit();
    }
    
    public void setting_game()
    {
        //SceneManager.LoadScene(1);
        plane.gameObject.SetActive(false);
        QuitButton.gameObject.SetActive(false);
        Title.gameObject.SetActive(false);
        SettingText.gameObject.SetActive(false);

        playmusic.gameObject.SetActive(true);
        BackButton.gameObject.SetActive(true);
    }

    public void backToMenu()
    {
        plane.gameObject.SetActive(true);
        QuitButton.gameObject.SetActive(true);
        Title.gameObject.SetActive(true);
        SettingText.gameObject.SetActive(true);

        playmusic.gameObject.SetActive(false);
        BackButton.gameObject.SetActive(false);
    }

    public void OnEnterQuitText()
    {
        
        QuitText.GetComponent<Text>().color = Color.white;
    }

    public void onExitQuitText()
    {
        
        QuitText.GetComponent<Text>().color = Color.red;
    }

    public void OnEnterSettingText()
    {
        BackButton.GetComponent<Text>().color = Color.white;
        SettingText.GetComponent<Text>().color = Color.white;
    }

    public void OnExitSettingText()
    {
        BackButton.GetComponent<Text>().color = Color.red;
        SettingText.GetComponent<Text>().color = Color.red;
    }

    //void makeSingleIT()
    //{
    //    if (instance != null)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}

}

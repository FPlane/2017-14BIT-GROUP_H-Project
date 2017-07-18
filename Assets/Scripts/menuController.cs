using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class menuController : MonoBehaviour {

    public static menuController instance;

    public Text QuitText;
    public Text SettingText;

    public void playButton()
    {
        SceneManager.LoadScene(2);
    }

    public void setting_button()
    {
        SceneManager.LoadScene(1);
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
#if UNITY_STANDALONE_WIN
        print("Game is running on Windows");
        QuitText.gameObject.SetActive(true);
#elif UNITY_STANDALONE_OSX
        print("Game is running on OSX");
        QuitText.gameObject.SetActive(true);
<<<<<<< HEAD
#elif UNITY_ANDROID || UNITY_IOS
        QuitText.gameObject.SetActive(false);
=======
>>>>>>> 612b80ac21303cb759deaf7a63f725c07292d025
#endif
    }

    public void Quit_game()
    {
        Application.Quit();
    }
    
    public void setting_game()
    {
        SceneManager.LoadScene(1);
    }

    public void OnEnterQuitText()
    {
        print(1);
        QuitText.GetComponent<Text>().color = Color.white;
    }

    public void onExitQuitText()
    {
        print(2);
        QuitText.GetComponent<Text>().color = Color.red;
    }

    public void OnEnterSettingText()
    {
        print(1);
        SettingText.GetComponent<Text>().color = Color.white;
    }

    public void OnExitSettingText()
    {
        print(2);
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

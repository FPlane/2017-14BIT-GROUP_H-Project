using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuController : MonoBehaviour {

    public static menuController instance;



    public void playButton()
    {
        SceneManager.LoadScene("guide");
    }

    //public void exitButton()
    //{
    //    Application.Quit();
    //}

    void Awake()
    {
        makeSingleIT();
    }

    void makeSingleIT()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour {

    public static menuController instance;

    public void playButton()
    {
        SceneManager.LoadScene("gameplay");
    }

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

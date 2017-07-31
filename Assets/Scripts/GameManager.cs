using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public const string HIGH_SCORE = "High Score";


	// Use this for initialization
	void Awake () {
        makeInstance();
        FirstInit();

        //To reset high score, remove this comment once
        //PlayerPrefs.DeleteKey("FirstInit");

    }

    void FirstInit()
    {
        if (!PlayerPrefs.HasKey("FirstInit"))
        {
            print("First Init key not installed");
            PlayerPrefs.SetInt(HIGH_SCORE, 0);
            PlayerPrefs.SetInt("FirstInit", 0);
            PlayerPrefs.Save();
        } else
        {
            print("First Init key installed");
        }
    }

    void makeInstance()
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


    public void setHighScore(int distance)
    {
        PlayerPrefs.SetInt(HIGH_SCORE, distance);
        PlayerPrefs.Save();
        //Debug.Log(PlayerPrefs.GetFloat("highscore").ToString());
    }

    public int getHighScore()
    {
        return PlayerPrefs.GetInt(HIGH_SCORE);
    }



}

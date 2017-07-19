using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    private const string HIGH_SCORE = "highscore";


	// Use this for initialization
	void Start () {
        makeInstance();
        FirstInit();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setHighScore(float currentDistance)
    {
        PlayerPrefs.SetFloat("highscore", currentDistance);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetFloat("highscore").ToString());
    }

    public float getHighScore()
    {
        return PlayerPrefs.GetFloat(HIGH_SCORE);
    }

    void FirstInit()
    {
        if(!PlayerPrefs.HasKey("FirstInit"))
        {
            PlayerPrefs.GetInt("myfirstkey");
            PlayerPrefs.SetFloat(HIGH_SCORE, 0);
            PlayerPrefs.SetInt("FirstInit", 0);
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
}

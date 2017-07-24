using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour {

    public static GameSetting instance;



    public Toggle isPlay;

    // Use this for initialization
    void Awake () {
        //PlayerPrefs.DeleteKey("firstdownload");
        makeInstance();
        firstdownload();
        PlayerPrefs.GetInt("myfirstkey");
        Debug.Log(PlayerPrefs.GetInt("myfirstkey").ToString());
        print("menu load");
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("myfirstkey") == 1)
        {
            isPlay.isOn = true;
        }
        else if(PlayerPrefs.GetInt("myfirstkey") == 0)
        {
            isPlay.isOn = false;
        }
    }

    public void firstdownload()
    {
        if(!PlayerPrefs.HasKey("firstdownload"))
        {
            print("First Download key not installed");
            //PlayerPrefs.SetInt("myfirstkey", 0);
            PlayerPrefs.SetInt("firstdownload", 0);
            
        } else
        {
            print("First Download key installed");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
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

    public void mute()
    {
        if (isPlay.isOn == false)
        {
            if (gameObject.GetComponent<AudioSource>().pitch == 1)
            {

                gameObject.GetComponent<AudioSource>().pitch = 0;

                PlayerPrefs.SetInt("myfirstkey", 0);
                PlayerPrefs.Save();
                Debug.Log(PlayerPrefs.GetInt("myfirstkey").ToString());
            }
        }
        else if(isPlay.isOn == true)
        {
            if (gameObject.GetComponent<AudioSource>().pitch == 0)
            {

                gameObject.GetComponent<AudioSource>().pitch = 1;

                PlayerPrefs.SetInt("myfirstkey", 1);
                PlayerPrefs.Save();
                Debug.Log(PlayerPrefs.GetInt("myfirstkey").ToString());
            }
        }

    }
}

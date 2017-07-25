using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class optionController : MonoBehaviour {

    public static optionController instance;
    // get Toggle Music 
    public Toggle isPlay;
    public Text BackButtonText;
    public int muteIt;

    void Start()
    {
   

        PlayerPrefs.GetInt("myfirstkey");
        Debug.Log(PlayerPrefs.GetInt("myfirstkey").ToString());

        if(PlayerPrefs.GetInt("myfirstkey") == 1)
        {
            isPlay.isOn = false;
        } else
        {
            isPlay.isOn = true;
        }

        BackButtonText.GetComponent<Text>().color = Color.red;
    }

    public void back_button()
    {
        SceneManager.LoadScene(0);

    }

    public void onEnterBackButton()
    {
 
        BackButtonText.GetComponent<Text>().color = Color.white;
    }

    public void onExitBackButton()
    {
    
        BackButtonText.GetComponent<Text>().color = Color.red;
    }
   
    public void mute()
    {
        if(isPlay.isOn == true)
        {
            if (musicController.instance != null)
            {
                if (musicController.instance.GetComponent<AudioSource>().mute == true)
                {

                    musicController.instance.GetComponent<AudioSource>().mute = false;
              
                    PlayerPrefs.SetInt("myfirstkey", 0);
                    PlayerPrefs.Save();
                    Debug.Log(PlayerPrefs.GetInt("myfirstkey").ToString());
                }

            }
        } else
        {
            if (musicController.instance != null)
            {
                if (musicController.instance.GetComponent<AudioSource>().mute == false)
                {
                    musicController.instance.GetComponent<AudioSource>().mute = true;
             
                    PlayerPrefs.SetInt("myfirstkey", 1);
                    PlayerPrefs.Save();
                    Debug.Log(PlayerPrefs.GetInt("myfirstkey").ToString());
                }

            }
        }

    }

 


}

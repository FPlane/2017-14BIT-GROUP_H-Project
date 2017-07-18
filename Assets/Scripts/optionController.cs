using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class optionController : MonoBehaviour {

    // get Toggle Music 
    public Toggle isPlay;
    public Text BackButtonText;

    void Start()
    {
        BackButtonText.GetComponent<Text>().color = Color.red;
    }

    public void back_button()
    {
        SceneManager.LoadScene(0);

    }

    public void onEnterBackButton()
    {
        print(1);
        BackButtonText.GetComponent<Text>().color = Color.white;
    }

    public void onExitBackButton()
    {
        print(2);
        BackButtonText.GetComponent<Text>().color = Color.red;
    }
   
    public void mute()
    {
        if(isPlay.isOn)
        {
            if (musicController.instance != null)
            {
                if (musicController.instance.GetComponent<AudioSource>().mute == true)
                {
                    musicController.instance.GetComponent<AudioSource>().mute = false;
                }

            }
        } else
        {
            if (musicController.instance != null)
            {
                if (musicController.instance.GetComponent<AudioSource>().mute == false)
                {
                    musicController.instance.GetComponent<AudioSource>().mute = true;
                }

            }
        }

    }


}

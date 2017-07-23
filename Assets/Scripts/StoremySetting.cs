//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class StoremySetting : MonoBehaviour
//{

//     Use this for initialization
//    void Start()
//    {
//        PlayerPrefs.GetString("checkmute");
//        checkmute();
//        if (PlayerPrefs.GetString("checkmute") == "isMute")
//        {
//            if (musicController.instance != null)
//            {
//                musicController.instance.GetComponent<AudioSource>().mute = true;
//                print("Music is mute");
//            }
//        }
//    }

//     Update is called once per frame
//    void Update()
//    {

//    }

//    void checkmute()
//    {
//        if (musicController.instance != null)
//        {
//            if (musicController.instance.GetComponent<AudioSource>().mute == true)
//            {
//                PlayerPrefs.GetString("checkmute", "isMute");
//                PlayerPrefs.Save();
//                Debug.Log(PlayerPrefs.GetString("checkmute"));
//            }
//            else if (musicController.instance.GetComponent<AudioSource>().mute == false)
//            {
//                PlayerPrefs.GetString("checkmute", "notMute");
//                PlayerPrefs.Save();
//                Debug.Log(PlayerPrefs.GetString("checkmute"));
//            }
//        }
//    }
//}

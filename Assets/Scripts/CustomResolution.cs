//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CustomResolution : MonoBehaviour
//{

//    public static CustomResolution instance;

//    [SerializeField]
//    private int screenHeight;

//    [SerializeField]
//    private int screenWidth;

//    // Use this for initialization
//    void Start()
//    {
//        Screen.fullScreen = !Screen.fullScreen;
//        Screen.SetResolution(screenWidth, screenHeight, false);
//        //print(screenHeight);
//        //print(screenWidth);
//    }

//    void Awake()
//    {
//        makeSingleIT();
//    }

//    void makeSingleIT()
//    {
//        if (instance != null)
//        {
//            Destroy(gameObject);
//        }
//        else
//        {
//            instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamePlayMananger : MonoBehaviour {
    public static gamePlayMananger instance;
    void Awake()
    {
        makeSingleIT();
    }

    void makeSingleIT()
    {
        if(instance != null)
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

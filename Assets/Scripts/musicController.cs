using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicController : MonoBehaviour {

    public static musicController instance;

    void FixedUpdate()
    {
        if (optionController.instance != null)
        {
            print(optionController.instance.data);
        }
    }

    // Use this for initialization
    void Start () {
        
  

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingdata : MonoBehaviour {
    public static loadingdata instance;
    public int frame_rate = 60;
	// Use this for initialization
	void Start () {
        makeIntance();

        StartCoroutine("loading");
    }
	

    
	// Update is called once per frame
	void Update () {
 
        if (frame_rate != Application.targetFrameRate)
        {
            Application.targetFrameRate = frame_rate;
        }
	}

    IEnumerator loading()
    {

        yield return new WaitForSeconds(2);
        SceneManager.LoadSceneAsync(1);

    }

    private void makeIntance()
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

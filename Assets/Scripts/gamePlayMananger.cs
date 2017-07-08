using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamePlayMananger : MonoBehaviour {

    [SerializeField]
    private Button GuideButton;

    private void Awake()
    {
        Time.timeScale = 0f;
    }

    public void Guide_Button()
    {
        Time.timeScale = 1f;
        GuideButton.gameObject.SetActive(false);
    }

}

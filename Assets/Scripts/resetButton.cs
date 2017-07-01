using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetButton : MonoBehaviour {

	public void resetGame()
    {
        SceneManager.LoadScene("gameplay");
    }
}

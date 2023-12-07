using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToGame : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKey("space"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        if (Input.GetKey(KeyCode.C))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}

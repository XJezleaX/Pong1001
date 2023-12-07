using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToTitle : MonoBehaviour
{

    private AudioSource AudioSource;
    public GameObject ObjectMusic;
    public void Update()
    {
        if (Input.anyKey)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

    public void Start()
    {
        ObjectMusic = GameObject.FindWithTag("Music");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();
    }
}

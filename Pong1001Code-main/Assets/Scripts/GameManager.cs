using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    private int aiScore;
    public Ball ball;
    private int _playerLives = 100;
    private int _computerLives = 100;
    public TextMeshProUGUI ScoreDisplay1;
    public TextMeshProUGUI LivesDisplay1;
    public TextMeshProUGUI ScoreDisplay2;
    public TextMeshProUGUI LivesDisplay2;
    public AudioSource AudioSource;
    public Image HP1;
    public Image HP2;

    private void Start()
    {
        Destroy(GameObject.FindWithTag("Music"));
        HP1.fillAmount = 1.0f;
        HP2.fillAmount = 1.0f;
    }


    public void PlayerLives()
    {
        HP1.fillAmount -= 0.01f;
        _playerLives--;

        if(_playerLives == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }

    }

    public void ComputerLives()
    {
        HP2.fillAmount -= 0.01f;
        _computerLives--;

        if (_computerLives == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }

    }
}

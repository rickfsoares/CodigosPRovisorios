using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject GameOver;
    public TextMeshProUGUI scoreText;
    public static GameController instance;
    public int score;
   private void Awake()
   {
    instance = this;
    Time.timeScale = 1;
   }
   public void ShowGameOver()
   {
    GameOver.SetActive(true);
    Time.timeScale = 0;
   }

    public void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Debug.Log("Funciona");
    }
    
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

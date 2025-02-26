using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    void Start()
    {
     gameOverPanel.SetActive(true);
     if(GameManager.Instance){
        scoreText.text = "Score: " + GameManager.Instance.score.ToString();
     }
    }

    public void RestartGame(){
        SceneManager.LoadScene(0);
    }
}

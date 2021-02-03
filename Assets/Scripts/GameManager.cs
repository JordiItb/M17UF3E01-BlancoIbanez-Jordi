using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static float score;

    public Text scoreText;

    public AudioSource[] audios;
    public GameObject end;
    

    void Start(){

        Time.timeScale = 1f;

        score = 100f;

        scoreText.text = "Score: " + score;

    }

    void Update(){

        if(score <= 0f){

            scoreText.text = "Score: 0";

            endGame();

        }

    }

    
    public void setScore(int newScore){

        score += newScore;

        scoreText.text = "Score: " + score;

    }


    public void badAudio(){

        audios[0].Play();

    }

    public void goodAudio(){

        audios[1].Play();

    }

    public void Quit(){

        Application.Quit();

    }

    public void nextLevel(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void restartScene(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void endGame(){

        Time.timeScale = 0f;

        end.SetActive(true);

    }

}

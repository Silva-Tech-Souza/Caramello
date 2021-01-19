using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamecontroler : MonoBehaviour
{
    public int Score;
    public Text scoreText;
 

    void Start(){
        Time.timeScale = 1;
       
    }

    public void RestartGame(){
        if (menuinicio.jogoar == 1)
        {
            pontos.velocidade = 2.5f;
            menuinicio.stopmusica = 0;
            SceneManager.LoadScene(4);
        }else if(menuinicio.jogoar == 2)
        {
            pontos.velocidade = 2.5f;
            menuinicio.stopmusica = 0;
            SceneManager.LoadScene(1);
        }else
        {
            pontos.velocidade = 2.5f;
            menuinicio.stopmusica = 0;
            SceneManager.LoadScene(5);
        }
        
    }
}

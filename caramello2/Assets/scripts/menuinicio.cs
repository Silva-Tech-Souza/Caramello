using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuinicio : MonoBehaviour
{
    public GameObject pauserplay;
    public GameObject btnpauser;
    
    public static float jogoar;
    public float pauser = 0f;
    public static float stopmusica = 0f;
    public static bool paser;
    gamecontroler controller;

    public void PlayGame(){
        jogoar = 2f;
        SceneManager.LoadScene(4);
        
    }
    public void Historia(){
        SceneManager.LoadScene(6);
    }
    
    void Start()
    {
        controller = FindObjectOfType<gamecontroler>();
    }
    
    public void PlayMenu(){
        pontos.velocidade = 2.5f;
        menuinicio.stopmusica = 0;
        spawpipes.controlepulo = 0f;
        SceneManager.LoadScene(0);
    }

    public void PlayModoJogo(){
        spawpipes.controlepulo = 0f;
        pontos.velocidade = 2.5f;
        SceneManager.LoadScene(1);
    }
     public void PlayAgua(){
        spawpipes.controlepulo = 0f;
        pontos.velocidade = 2.5f;
        jogoar = 3f;
        SceneManager.LoadScene(5);
    }
    public void PlaPauser(){
        //paser = true;
       // dog.rigi.gravityScale = 10f;
       // dog.jampforcer = 0;
        paser = true;
        pauserplay.SetActive(true);
        
        btnpauser.SetActive(false);
        menuinicio.stopmusica = 1f;
        Time.timeScale = 0;
    } 
    

    public void PlaJogo(){
        paser = false ;
      
        spawpipes.controlepulo = 0f;
        pontos.velocidade = 2.5f;
        SceneManager.LoadScene(1);
        menuinicio.stopmusica = 0f;
        Time.timeScale = 1;
       
    }

    public void PlayCredito(){
        spawpipes.controlepulo = 0f;
         pontos.velocidade = 2.5f;
        SceneManager.LoadScene(3);
    }

    public void PlayAr(){
        jogoar = 1f;
        spawpipes.controlepulo = 0f;
         pontos.velocidade = 2.5f;
        menuinicio.stopmusica = 0;
        SceneManager.LoadScene(2);
    }

    public void QuitGame(){
        spawpipes.controlepulo = 0f;
        pontos.velocidade = 2.5f;
        Application.Quit();
    }
}

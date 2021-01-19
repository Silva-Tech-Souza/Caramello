using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pontos : MonoBehaviour
{
    gamecontroler controller;
    public static float velocidade = 2.5f, velocimar = 3f;
    
    void Start()
    {
        controller = FindObjectOfType<gamecontroler>();   
    }
    void OnTriggerEnter2D(Collider2D colizor)
    {
        
        
    }
    void OnTriggerExit2D(Collider2D colizor)
    {
        if (colizor.gameObject.tag == "ponto")
        {
            velocidade += 0.099f;
            velocimar += 0.009f;
            controller.Score++;
            controller.scoreText.text = controller.Score.ToString();
        }
    
        
    }
}

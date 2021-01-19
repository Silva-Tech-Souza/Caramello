using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pipes : MonoBehaviour
{
        float speed;
        gamecontroler controller;
        public float velocidade = 2.5f;

        void Start()
        {
        speed = 2f;
        controller = FindObjectOfType<gamecontroler>();   
        }

        void Update()
        {
        if (menuinicio.jogoar != 3 ){
        if (controller.Score >= 13)
        {
             transform.position += Vector3.left * pontos.velocidade * Time.deltaTime;   
        }else{
              transform.position += Vector3.left * 2.5f * Time.deltaTime;   
        }

        }

        if (menuinicio.jogoar == 3)
        {
        if (controller.Score >= 42)
        {
          transform.position += Vector3.down *  3.5f * Time.deltaTime;
        }else{
          transform.position += Vector3.down *  3f * Time.deltaTime;
        }
        }    
        }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melhoria : MonoBehaviour
{
    
    public Animator anim;
    gamecontroler controller;
    public GameObject fundo1;
    public GameObject fundo2;
    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<gamecontroler>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.Score >= 50 ){
            anim.SetBool("correndo", true);
            anim.SetBool("chao_rapido", true);
            anim.SetBool("voo_rapido", true);
            anim.SetBool("nado_rapido", true);
        }

          if (controller.Score >= 50 ){
           fundo1.SetActive(false);
           fundo2.SetActive(true);
        }
        
    }
}

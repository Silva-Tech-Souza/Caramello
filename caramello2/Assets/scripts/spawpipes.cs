using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spawpipes : MonoBehaviour
{
    public GameObject pipe, pescachao;
    public float height;
    gamecontroler controller;
    public float maxTime = 0.9999999f;
    private float time = 0f;
    public static float controlepulo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if (menuinicio.jogoar == 1)
        {
        GameObject newPipe = Instantiate(pipe);
        controller = FindObjectOfType<gamecontroler>();   
        newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
        
        }else if (menuinicio.jogoar == 2)
        {
        GameObject newPipe = Instantiate(pipe);
        controller = FindObjectOfType<gamecontroler>();   
        newPipe.transform.position =  transform.position + new Vector3( Random.Range(-height, height), 0,0); 
        
        }else{
        GameObject newPipe = Instantiate(pescachao);
        controller = FindObjectOfType<gamecontroler>();   
        newPipe.transform.position =  transform.position + new Vector3(Random.Range(-5, 5f), 0,0); 
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pontos.velocidade = 2.5f;
            SceneManager.LoadScene(2);
            controlepulo = 0f;
        }
      time += Time.deltaTime;
        if(time > maxTime){

            if (menuinicio.jogoar == 1)
            {
                if (controller.Score >= 13 && controller.Score <= 17)
                {
               
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>(); 
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
                Destroy(newPipe,9f);
                time = 0.60f; 
                }else if (controller.Score >= 17 && controller.Score <= 22)
                {
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>(); 
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
                Destroy(newPipe,8f);
                time = 0.80f; 
                }else if (controller.Score >= 23 && controller.Score <= 28)
                {
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>(); 
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
                Destroy(newPipe,8f);
                time = 0.85f; 
                }else if (controller.Score >= 29 && controller.Score <= 34)
                {
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>(); 
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
                Destroy(newPipe,8f);
                time = 0.90f; 
                } else if (controller.Score >= 35  && controller.Score <= 40)
                {
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>(); 
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
                Destroy(newPipe,7f);
                time = 0.95f; 
                }else if (controller.Score >= 41  && controller.Score <= 46)
                {
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>(); 
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
                Destroy(newPipe,7f);
                time = 0.9999f; 
                }else if (controller.Score >= 47 )
                {
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>(); 
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
                Destroy(newPipe,7f);
                time = 0.999999f;
                }
                else{
                
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>(); 
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-3, 4),0); 
                Destroy(newPipe,9f);
                time = 0; 
                }
               
            }else if (menuinicio.jogoar == 2){
                if (controller.Score >= 13 && controller.Score <= 16)
                {
                    GameObject newPipe = Instantiate(pipe);
                    controller = FindObjectOfType<gamecontroler>();  
                    newPipe.transform.position =  transform.position + new Vector3(2, 0,0); 
                    Destroy(newPipe, 9f);
                    time = 0f; 
                }else if (controller.Score >= 17 && controller.Score <= 22)
                {
                    GameObject newPipe = Instantiate(pipe);
                    controller = FindObjectOfType<gamecontroler>();  
                    newPipe.transform.position =  transform.position + new Vector3(Random.Range(-0.9f, 2), 0,0);  
                    Destroy(newPipe, 9f);
                    time = 0.53f; 
                }else if (controller.Score >= 23 )
                {
                    GameObject newPipe = Instantiate(pipe);
                    controller = FindObjectOfType<gamecontroler>();  
                    newPipe.transform.position =  transform.position + new Vector3(Random.Range(-0.9f, 2), 0,0); 
                    Destroy(newPipe, 9f);
                    time = 0.66f; 
                }
                else{
                controlepulo = 1f;
                GameObject newPipe = Instantiate(pipe);
                controller = FindObjectOfType<gamecontroler>();  
                newPipe.transform.position =  transform.position + new Vector3( Random.Range(0.3f, 2), 0,0);  
                Destroy(newPipe, 9f);
                time = 0; 
                }
            
            }else if (menuinicio.jogoar == 3){
                if (controller.Score >= 8 && controller.Score <= 13)
                {
                GameObject newPipe = Instantiate(pescachao);
                controller = FindObjectOfType<gamecontroler>();   
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-6, 6f), 0,0); 
                Destroy(newPipe, 9f);
                time = 0.62f; 
                }else if (controller.Score >= 14 && controller.Score <= 19)
                {
                GameObject newPipe = Instantiate(pescachao);
                controller = FindObjectOfType<gamecontroler>();   
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-6, 6f), 0,0); 
                Destroy(newPipe, 9f);
                time = 0.82f; 
                }else if (controller.Score >= 20 && controller.Score <= 26)
                {
                GameObject newPipe = Instantiate(pescachao);
                controller = FindObjectOfType<gamecontroler>();   
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-6, 6f), 0,0); 
                Destroy(newPipe, 9f);
                time = 0.92f; 
                }else if (controller.Score >= 27 && controller.Score <= 31)
                {
                GameObject newPipe = Instantiate(pescachao);
                controller = FindObjectOfType<gamecontroler>();   
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-6, 6f), 0,0); 
                Destroy(newPipe, 9f);
                time = 0.98f; 
                }
                else if (controller.Score >= 32   )
                {
                GameObject newPipe = Instantiate(pescachao);
                controller = FindObjectOfType<gamecontroler>();   
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-6, 6f), 0,0); 
                Destroy(newPipe, 9f);
                time = 0.999f; 
                }else{
                GameObject newPipe = Instantiate(pescachao);
                controller = FindObjectOfType<gamecontroler>();   
                newPipe.transform.position =  transform.position + new Vector3(Random.Range(-6, 6f), 0,0); 
                Destroy(newPipe, 9f);
                time = 0; 
                }
               
            } 
        }
        
    }
}

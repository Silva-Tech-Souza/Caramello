using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class esquerda : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
     public float Speed;
     public static float input;
     public float sensibilidade = 3;
     public bool press;

     public void OnPointerDown(PointerEventData evento){
        press = true;
     }
     public void OnPointerUp(PointerEventData evento){
        press = false;
     }

    // Update is called once per frame
    void Update()
    {
        
        
        if(press){
            input += Time.deltaTime *  sensibilidade;
            
        }else
        {
            input -= Time.deltaTime * sensibilidade;
        }      
       
       input = Mathf.Clamp(input, 0, 1);    
       }

    
}

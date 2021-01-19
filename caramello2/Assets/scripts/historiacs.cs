using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class historiacs : MonoBehaviour
{
     public GameObject um, dois,tres,quatro,cinco, sex, cetavoltar;
     public int slide = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     public void cliqueslide(){
        if(slide==0){
            dois.SetActive(true);
            um.SetActive(false);
            cetavoltar.SetActive(true);
        }else if(slide==1){
            dois.SetActive(false);
            tres.SetActive(true);
        }else if(slide==2){
            dois.SetActive(false);
            tres.SetActive(false);
            quatro.SetActive(true);
        }else if(slide==3){
            quatro.SetActive(false);
            tres.SetActive(false);
            cinco.SetActive(true);
        }else if(slide==4){
            quatro.SetActive(false);
            cinco.SetActive(false);
            sex.SetActive(true);
        }
        
        slide++;
    }
    public void cliquevoltar(){
          if(slide==5){
            sex.SetActive(false);
            cinco.SetActive(true);
        }else if(slide==3){
            quatro.SetActive(true);
            cinco.SetActive(false);
        }else if(slide==3){
            quatro.SetActive(false);
            tres.SetActive(true);
        }else if(slide==2){
            dois.SetActive(true);
            tres.SetActive(false);
        }else if(slide==1){
            cetavoltar.SetActive(false);
            um.SetActive(true);
            dois.SetActive(false);
            tres.SetActive(false);
            quatro.SetActive(false);
        }
        
        slide--;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
    {
         SceneManager.LoadScene(0);
    }

    }

    
}

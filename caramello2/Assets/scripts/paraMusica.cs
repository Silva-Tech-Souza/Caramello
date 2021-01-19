using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class paraMusica : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (menuinicio.stopmusica == 1)
        {
            audio.Stop();
        }else if(menuinicio.stopmusica == 0){
            audio.Play();
            menuinicio.stopmusica = 3;
        }else{

        }
           
    }
}

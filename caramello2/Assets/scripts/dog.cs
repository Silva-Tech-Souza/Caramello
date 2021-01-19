using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dog : MonoBehaviour
{
    public GameObject gameover;
    public GameObject _buton;
    Button _component;
    public GameObject menu; 
    public GameObject pauser;
    public float speed = 1f;
    public  static Rigidbody2D rigi;
    private AudioSource audio;
    gamecontroler controller;
    public float dirsquer = 4f;
    public float position2 = 785f;
    public Vector3 positionmause;
    //menuinicio fasejogo;
    public static float  jampforcer = 5f;
    public static bool isJump = false;
    public static float tiro; 
    public float clique = 0;

    public float movimento = 0;

    void Start()
    {
        _component = _buton.GetComponent<Button>();  
        controller = FindObjectOfType<gamecontroler>();   
       // fasejogo = FindObjectOfType<menuinicio>();
        rigi = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        menu.SetActive(true);
        pauser.SetActive(true);
       
        menuinicio.stopmusica = 0f;
    }

   
      
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape)){
        spawpipes.controlepulo = 0f;
        SceneManager.LoadScene(2);
        }
        float position = Input.mousePosition.y;
        print(position + "   -  " + position2);

        if (menuinicio.jogoar == 1)
        {
            if(Input.GetMouseButtonDown(0) &&  position < position2){
            audio.Play();
            rigi.velocity = Vector2.up * speed;
            }
            if (controller.Score >= 0 &&  controller.Score < 15){
            rigi.gravityScale = 0.6f;
            speed = 3f;
            
            }
            if (controller.Score >= 16 && controller.Score < 22){
        
            rigi.gravityScale = 1.4f;
            speed = 4.22f;
        
            }
            if (controller.Score >=  23){
            
            rigi.gravityScale = 1.8f;
            speed = 4.82f;
            
            }
        }
        else if (menuinicio.jogoar == 2){
            if(!isJump && Input.GetMouseButtonDown(0) && position < position2  && spawpipes.controlepulo == 1 ){
                audio.Play();
               
                if(menuinicio.paser == false){
                    rigi.AddForce(new Vector2(0f, jampforcer), ForceMode2D.Impulse);
                }
                
            }
           
            if (controller.Score >= 12 &&  controller.Score < 16){
            rigi.gravityScale = 1f;
            jampforcer = 6.8f;
            }
            else if (controller.Score >= 17 &&  controller.Score < 20){
            rigi.gravityScale = 1.3f;
            jampforcer = 7.2f;
            }
            else if (controller.Score >= 21 && controller.Score < 27){
            rigi.gravityScale = 1.5f;
            jampforcer = 7.99f;
            }
            else if (controller.Score >= 28)
            {
            rigi.gravityScale = 1.6f;
            jampforcer = 8.2f;
            }
        }
        else if (menuinicio.jogoar == 3){       
    
            transform.position += Vector3.left * esquerda.input*  3.6f* Time.deltaTime;   
            transform.Translate(3.6f* tartaruga.input * Time.deltaTime, 0, 0);
            
        }
 
    }

    
    void OnCollisionEnter2D(Collision2D colisor)
    {
    if (colisor.gameObject.tag == "cano1"){
        audio.Stop();
        menuinicio.stopmusica = 1;
        gameover.SetActive(true);
        menu.SetActive(false);
        pauser.SetActive(false);
        Time.timeScale = 0;
    
    }
    }}


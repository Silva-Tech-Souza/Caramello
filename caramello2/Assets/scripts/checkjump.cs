using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class checkjump : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }
  
    void OnCollisionEnter2D(Collision2D colisor)
    {
        
            if (colisor.gameObject.tag == "chao")
            {
                dog.isJump = false;
            }
        
    }

    void OnCollisionExit2D(Collision2D colisorexit)
    {
        
        if (colisorexit.gameObject.tag == "chao")
        {
            dog.isJump = true;
        }
        
    }

}

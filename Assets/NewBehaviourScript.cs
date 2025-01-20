using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool butonStartPressed = false;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("start game"); 
       
       Debug.Log("нажать W");
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.W))
        {
            butonStartPressed = true;
        }

       if(butonStartPressed == false){
        Debug.Log("нажать W");
        }  
       // butonStartPressed=true;
       //}
    }
}

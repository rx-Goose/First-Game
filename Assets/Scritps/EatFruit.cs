using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFruit : MonoBehaviour
{ 
    MeshRenderer renderer;
    void Start() 
    {        
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.tag == "Player")
        {

            renderer.enabled = false;
            
        }
    }
}

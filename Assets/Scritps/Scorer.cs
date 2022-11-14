using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit" && other.gameObject.tag != "Fruit")
        {
            if(score>0)
            {
                score--; 
            }
            Debug.Log($"Your score is {score}");

        }  else if(other.gameObject.tag == "Fruit"){
            
            score++;
            //GetComponent<MeshRenderer>().enabled = false;
            Debug.Log($"Your score is {score}");

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        rigidbody.useGravity = false;
        //GetComponent<Rigidbody>().UseGravity.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);

        if (Time.time > timeToWait)
        {
            //Debug.Log("GJ");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}

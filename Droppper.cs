using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droppper : MonoBehaviour
{  [SerializeField] float timetowait = 5f;
    MeshRenderer Renderer;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {   Renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        
        Renderer.enabled = false;
        rigidBody.useGravity =false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timetowait)
        {
            Debug.Log("time elapsed ");
            Renderer.enabled = true;
            rigidBody.useGravity = true;


        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatinh : MonoBehaviour
{
   [SerializeField] float Xangle = 1f;
   [SerializeField] float Yangle = 0f;
   [SerializeField] float Zangle = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Xangle,Yangle,Zangle);
    }
}

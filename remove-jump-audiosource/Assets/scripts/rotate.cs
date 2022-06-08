using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotatespeed;
    
    void Update()
    {
        transform.Rotate(Vector3.up * rotatespeed * Time.deltaTime);        
    }


}

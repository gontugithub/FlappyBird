using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    private float _velocity = 0.65f;


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _velocity * Time.deltaTime;   
    }
}

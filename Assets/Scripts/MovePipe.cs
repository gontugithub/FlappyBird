using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    private float _velocity = 0.65f;
    public float _timeAlive;
    private float currentTime;


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _velocity * Time.deltaTime;  
        
        
        if (currentTime >= _timeAlive)
        {
            currentTime = 0;
            gameObject.SetActive(false);
        }
        currentTime += Time.deltaTime;
    }
}

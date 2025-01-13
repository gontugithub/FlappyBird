using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Fly : MonoBehaviour
{
    // BIRD VARIABLES

    private float _velocity = 1.5f;

    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {

        // we save the actual bird rigidBody inside > _rb

        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // when we click the left click, we add velocity to the vector up, so goes up

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector2.up * _velocity;
        }
        {

        }


    }
}

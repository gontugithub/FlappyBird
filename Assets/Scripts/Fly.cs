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

    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {

        // we save the actual bird rigidBody inside > _rb

        _rb = GetComponent<Rigidbody2D>();

        _animator = GetComponent<Animator>();
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.Play("Death", -1, 0f);

        GameManager.Instance.GameOver();
    }
}

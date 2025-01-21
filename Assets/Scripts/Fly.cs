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
    public AudioClip deathAudioClip;

    public Interstitial _adManager;

    // Start is called before the first frame update
    void Start()
    {

        // we save the actual bird rigidBody inside > _rb

        _rb = GetComponent<Rigidbody2D>();

        _animator = GetComponent<Animator>();

        _adManager = FindObjectOfType<Interstitial>();
    }

    // Update is called once per frame
    void Update()
    {
        // Detecta clic del ratón, tecla de espacio o toque en pantalla
#if UNITY_STANDALONE || UNITY_EDITOR
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector2.up * _velocity;
        }
#elif UNITY_ANDROID || UNITY_IOS
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
    {
        _rb.velocity = Vector2.up * _velocity;
    }
#endif
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {



        AudioManager.instance.PlayAudio(deathAudioClip, "Death");
        _animator.Play("Death", -1, 0f);
        FindObjectOfType<Interstitial>().ShowAd(); // Llama al AdManager para mostrar el

        GameManager.Instance.GameOver();
    }
}

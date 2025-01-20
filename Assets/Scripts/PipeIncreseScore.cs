using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeIncreaseScoreSound: MonoBehaviour
{
    public AudioClip shootAudioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.UpdateScore();
            AudioManager.instance.PlayAudio(shootAudioClip, "Point");

        }
    }
}

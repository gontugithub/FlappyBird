using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private List<GameObject> activeAudios; // lo que esta sonando

    private void Awake()
    {

        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            activeAudios = new List<GameObject>();
        } else
        {
            Destroy(gameObject);
        }
    
    }

    public AudioSource PlayAudio(AudioClip clip, string objectName, float volume = 1, bool isLoop = false)
    {
        GameObject audioObjetct = new GameObject(objectName);
        AudioSource audioSourceComponent = audioObjetct.AddComponent<AudioSource>();
        audioSourceComponent.clip = clip;
        audioSourceComponent.volume = volume;
        audioSourceComponent.loop = isLoop;
        audioSourceComponent.Play();

        if (!isLoop)
        {
            activeAudios.Add(audioObjetct);
            //  COMO LLAMAR A UNA CORUTINA
            StartCoroutine(CheckAudio(audioSourceComponent));
        }

        

        return audioSourceComponent;
    }
        IEnumerator CheckAudio(AudioSource audioSource)
        {
            while (audioSource.isPlaying)
            {
                yield return new WaitForSeconds(.2f);
            }

            Destroy(audioSource.gameObject);
        }



   
}

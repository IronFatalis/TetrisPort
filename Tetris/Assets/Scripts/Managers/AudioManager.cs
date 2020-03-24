using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip Music0;
    public AudioClip Music1;
    public AudioClip Music2;
    public AudioClip Music3;

    private AudioSource audioSource;

    private int CurrentMusic = 0;
    private int NewMusic = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(Music0);
    }

    // Update is called once per frame
    void Update()
    {
        if (NewMusic != SelectType.SelectMusic)
        {
            NewMusic = SelectType.SelectMusic;
        }

        if (CurrentMusic != NewMusic)
        {
            audioSource.Stop();
            audioSource.loop = true;
            CurrentMusic = NewMusic;

            if (CurrentMusic == 0)
            {
                audioSource.PlayOneShot(Music0);
            }
            else if (CurrentMusic == 1)
            {
                audioSource.PlayOneShot(Music1);
            }
            else if (CurrentMusic == 2)
            {
                audioSource.PlayOneShot(Music2);
            }
            else if (CurrentMusic == 3)
            {
                audioSource.PlayOneShot(Music3);
            }
            
        }
    }
}

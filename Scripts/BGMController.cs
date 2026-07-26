using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;   // 循環播放
        audioSource.playOnAwake = true; // 遊戲開始就播放
    }

    public void PlayBGM()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
    }

    public void StopBGM()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
    }
}
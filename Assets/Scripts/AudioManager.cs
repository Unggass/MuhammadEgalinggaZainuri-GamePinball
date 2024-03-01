using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource bgmAudio;
    public AudioSource sfxAudio;
    public AudioSource sfxSwitchAudio;

    // Start is called before the first frame update
    void Start()
    {
        PlayBgm();
    }

    private void PlayBgm()
    {
        bgmAudio.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudio, spawnPosition, Quaternion.identity);
    }
    public void PlaySwitchSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchAudio, spawnPosition, Quaternion.identity);
    }
}

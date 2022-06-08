using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    private void Start()
    {
        //AudioManager.Instance.PlayBackgroundMusic(AudioManager.BackgroundMusic.BackgroundMusic1);
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire1);
        if (Input.GetButtonDown("Fire2"))
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire2);
        if (Input.GetButtonDown("Fire3"))
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire3);
        if (Input.GetButtonDown("Jump"))
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Jump);
    }
}

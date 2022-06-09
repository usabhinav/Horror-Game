using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DelayAudioPlay : MonoBehaviour
{
    AudioSource audioData;
    [SerializeField] public int delay;

    IEnumerator Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.mute = true;
        yield return new WaitForSeconds(delay);
        audioData.mute = false;
        audioData.Play(0);
    }
}

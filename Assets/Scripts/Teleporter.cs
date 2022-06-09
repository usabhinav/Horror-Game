using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Teleporter : MonoBehaviour
{
    private int counter = 0;
    private float waitTime = 0;
    [SerializeField] public int radius;
    [SerializeField] public float waitTimeRangeMin;
    [SerializeField] public float waitTimeRangeMax;
    private float startX;
    private float startY;
    private float startZ;

    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
        startZ = transform.position.z;
        audioData = GetComponent<AudioSource>();
        waitTime = Random.Range(waitTimeRangeMin, waitTimeRangeMax);
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter > (audioData.clip.length + waitTime) * 80)
        {
            counter = 0;
            transform.position = new Vector3(Random.Range(-radius + startX, radius + startX),
                                             Random.Range(startY, radius + startY),
                                             Random.Range(-radius + startZ, radius + startZ));
            audioData.Play(0);
            waitTime = Random.Range(waitTimeRangeMin, waitTimeRangeMax);
        }
    }
}

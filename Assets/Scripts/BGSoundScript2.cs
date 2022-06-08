using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSoundScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private static BGSoundScript2 instance = null;
    public static BGSoundScript2 Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource msc;
    private static Music obje = null;
    static public bool musicplay = true;
    static public float volumeValue;
    void Awake()
    {
        if (obje == null)
        {
            obje = this;
            DontDestroyOnLoad(this);
        }
        else if (this != obje)
        {
            Destroy(gameObject);
        }
    }
    public void musicVolume()
    {
        msc.volume = volumeValue;
    }
    // Start is called before the first frame update
    void Start()
    {
        msc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!musicplay) msc.mute = true;
        if (musicplay) msc.mute = false;

    }
}

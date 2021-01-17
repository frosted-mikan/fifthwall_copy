using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrophoneInput : MonoBehaviour
{
    //string micName = "Built-in Microphone";
    //string micNameMac = "MacBook Pro Microphone";

    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        Debug.Log(Microphone.devices[0].ToString());
        audio.clip = Microphone.Start(Microphone.devices[0].ToString(), true, 1, 44100);
        audio.loop = true;
        while (!(Microphone.GetPosition(null) > 0)) { }
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
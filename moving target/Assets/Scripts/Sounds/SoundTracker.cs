using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource[] soundFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("shoot")){
            soundFX[0].Play();
        }
    }
    public void hitBtn()
    {
        soundFX[1].Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour

{
    public AudioSource AudioSource;
    public float delay = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        AudioSource.PlayDelayed(delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioSource HitButton;

    // Start is called before the first frame update
    void Start()
    {
        HitButton = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        HitButton.Play();
    }
}

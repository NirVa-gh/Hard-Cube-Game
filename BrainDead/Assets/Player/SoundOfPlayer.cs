using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfPlayer : MonoBehaviour
{
    public AudioSource MoveOfPlayer;
    public GameObject Player;
    public Rigidbody PlayerRb;
    // Start is called before the first frame update
    void Start()
    {
        MoveOfPlayer = GetComponent<AudioSource>();
        PlayerRb = Player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerRb.velocity.z != 0 )
        {
            //print(PlayerRb.velocity.z);
            MoveOfPlayer.Play();           
        }
        else
        {
            MoveOfPlayer.Stop();
        }
      
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public Rigidbody2D rigidPlayer;
    public SpriteRenderer spritePlayer;
    public float speed;

    public AudioSource playerSound;
    public AudioClip engineClip;




    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        rigidPlayer.velocity = new Vector2(moveX * speed, rigidPlayer.velocity.y);

        float moveY = Input.GetAxisRaw("Vertical");
        rigidPlayer.velocity = new Vector2(rigidPlayer.velocity.x, moveY * speed);

        if (!Input.GetKey(KeyCode.W))
        {
            playerSound.clip = engineClip;
            playerSound.Play();
        }



    }
}

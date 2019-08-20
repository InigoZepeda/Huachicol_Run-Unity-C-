using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public bool camina;
    public float speed;
    public Rigidbody2D rigidEnemy;
    public int damage;

    public bool walkingRight;


    public void Update()
    {
        if (camina)
        {
            if (walkingRight)
            {
                rigidEnemy.velocity = new Vector2(speed, rigidEnemy.velocity.y);
            }
            else
            {
                rigidEnemy.velocity = new Vector2(-speed, rigidEnemy.velocity.y);
            }

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();

            if (transform.position.x > player.transform.position.x)
            {
                player.TakeDamage(damage, true);
            }
            else
            {
                player.TakeDamage(damage, false);
            }

        }

        walkingRight = !walkingRight; // el ! es para negar el valor
    }
    

        

   


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public bool camina;
    public float speed;
    public Rigidbody2D rigidCar;
    public int damage;

    public bool walkingRight;


    public void Update()
    {
        if (camina)
        {
            if (walkingRight)
            {
                rigidCar.velocity = new Vector2(rigidCar.velocity.y, -speed);
            }
            else
            {
                rigidCar.velocity = new Vector2(rigidCar.velocity.y, speed);
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
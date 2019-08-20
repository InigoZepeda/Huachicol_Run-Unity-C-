using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int damage;
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
    }
}

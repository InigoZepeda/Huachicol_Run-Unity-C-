using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public int health;
    public Rigidbody2D rigidPlayer;

    public void TakeDamage(int damage, bool fromRight)
    {
        health = health - damage;
        if (health > 0)
        {
            if (fromRight)
            {
                rigidPlayer.AddForce(new Vector2(-400, 400));
            }
            else
            {
                rigidPlayer.AddForce(new Vector2(400, 400));
            }
        }
        else
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("LoadScene");

        }

    }

}
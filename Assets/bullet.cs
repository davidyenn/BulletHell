using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Wall":
               Destroy(gameObject); 
               break;

            case "Boss":
                BossController health = collision.GetComponent<BossController>();
                if (health != null)
                {
                    health.TakeDamage(1);
                    Debug.Log("kirby damaged");
                }
                Destroy(gameObject);
                break;

            case "Player":
                PlayerController hp = collision.GetComponent<PlayerController>();
                if (hp != null)
                {
                    hp.TakeDamage(1);
                    Debug.Log("Player damaged");
                }
                Destroy(gameObject);
                break;
        }
    }
}
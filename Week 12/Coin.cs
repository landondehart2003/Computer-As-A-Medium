using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifetime = 3f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Find the GameManager and add 1 to the score
            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null)
            {
                gm.AddScore(1);
            }

            // Destroy the coin upon collection
            Destroy(gameObject);
        }
    }
}
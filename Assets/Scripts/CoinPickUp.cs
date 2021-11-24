using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    [SerializeField] AudioClip coinPickUpSound;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(coinPickUpSound, transform.position);
        FindObjectOfType<GameSession>().AddScore(50);
        Destroy(gameObject);
    }
}

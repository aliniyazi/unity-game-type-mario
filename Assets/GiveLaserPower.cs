using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveLaserPower : MonoBehaviour
{
    [SerializeField] Player player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        player.Gems++;
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LazerDestroy());
        
    }
    IEnumerator LazerDestroy()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}

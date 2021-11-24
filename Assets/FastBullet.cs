using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBullet : MonoBehaviour
{
    [SerializeField] float Speed =5f;
    [SerializeField] GameObject Bulet;

    void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject bullet = Instantiate(Bulet, new Vector2(85f,29.47f),Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-Speed, 29.47f);
        Debug.Log("H");
    }
}

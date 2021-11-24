using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float EnemySpeed = 1f;
    Rigidbody2D MyRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingLeft())
        {
            MyRigidbody.velocity = new Vector2(EnemySpeed, 0f);
        }
        else
        {

            MyRigidbody.velocity = new Vector2(-EnemySpeed, 0f);
        }
    }
    bool IsFacingLeft()
    {
        return transform.localScale.x < 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.localScale = new Vector2(Mathf.Sign(MyRigidbody.velocity.x), 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBug : MonoBehaviour
{
    [SerializeField] float ProjectileSpeed = 2f;
    [SerializeField] float ShotCounter;
    [SerializeField] float minTimeBettwenShots = 0.2f;
    [SerializeField] float maxTimeBettwenShots = 3f;
    [SerializeField] GameObject LaserFire;
    [SerializeField] AudioClip lazeraudio;
    // Start is called before the first frame update
    void Start()
    {
        ShotCounter = Random.Range(minTimeBettwenShots, maxTimeBettwenShots);
    }

    // Update is called once per frame
    void Update()
    {
        ShotCounter -= Time.deltaTime;
        if (ShotCounter <= 0)
        {
            Fire();
            ShotCounter = Random.Range(minTimeBettwenShots, maxTimeBettwenShots);

        }
    }
    private void Fire()
    {

        GameObject laser = Instantiate(LaserFire, transform.position, Quaternion.identity) as GameObject;
        AudioSource.PlayClipAtPoint(lazeraudio, transform.position);
        laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -ProjectileSpeed);



    }
}

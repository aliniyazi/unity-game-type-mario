using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints;
    [SerializeField] float moveSpeed = 2f;
    int waypointIndex = 0;
        // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(waypointIndex <= waypoints.Count-1)
        {
            var targetPosition = waypoints[waypointIndex].transform.position;
            var movethisFrame = moveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movethisFrame);
            if(transform.position == targetPosition)
            {
                waypointIndex++;
            }

        }
        else
        {
            waypointIndex = 0;
        }
    }
}

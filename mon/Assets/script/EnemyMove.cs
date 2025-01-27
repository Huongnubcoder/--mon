using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Timeline;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PlayerPosition;
    public float MoveSpeed = 3f;
    public bool IsChasing = false;
    public Vector3 StartPoint;
    public float ReturnThreshold = 0.1f;
    void Start()
    {
        StartPoint = transform.position;
        if (PlayerPosition == null)
        {
            PlayerPosition = GameObject.FindWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsChasing)
        {
            transform.position = Vector2.MoveTowards(transform.position, PlayerPosition.position, MoveSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, PlayerPosition.position) > 3f) {
                
                IsChasing = false;
            }
        }
        else {
            transform.position = Vector2.MoveTowards(transform.position, StartPoint, MoveSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, StartPoint) < ReturnThreshold)
            {
                transform.position = StartPoint;
            }
            if (Vector2.Distance(transform.position, PlayerPosition.position) < 3f) { 
                IsChasing = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float speed = 2f;

    private Transform target;
    private int pathIndex = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = LevelManager.instance.waypoints[pathIndex];
    }

    private void Update()
    {
        if (Vector2.Distance(target.position, this.transform.position) <= 0.1f)
        {
            pathIndex++;
        }

        if (pathIndex == LevelManager.instance.waypoints.Length)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            target = LevelManager.instance.waypoints[pathIndex];
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * speed;
    }

}

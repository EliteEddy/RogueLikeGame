using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Enemy_Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Transform player;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        rb.linearVelocity = direction * speed;
    }
}

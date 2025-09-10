using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{

    public Transform player;       // Reference to the player GameObject
    public float rotationSpeed = 10f;  // Degrees per second
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<EnemyScript>().TakeDamage();
        }
    }

    void Update()
    {
        
        
            // Rotate around the player's position on the Z-axis (for 2D)
            transform.RotateAround(player.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        
    }
}

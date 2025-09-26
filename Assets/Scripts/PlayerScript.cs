using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] public Vector3 Direction;
    [SerializeField] float MoveSpeedAmplifier = 1f;
    public Rigidbody2D rb; // add a Rigidbody2D reference

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // get the Rigidbody2D
    }

    private void Update()
    {
        Direction.x = Input.GetAxisRaw("Horizontal");
        Direction.y = Input.GetAxisRaw("Vertical");

        Direction = Direction.normalized;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(Direction.x, Direction.y) * MoveSpeedAmplifier;
    }
}

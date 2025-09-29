using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float rotationSpeed = 90f; // degrees per second
    [SerializeField] private float radius = 2f;
    [SerializeField] private float zRotationOffset = 90f; // additional rotation in degrees

    private Vector3 offset;

    private void Start()
    {
        // Initialize offset with the starting radius
        offset = new Vector3(radius, 0, 0);
    }

    private void Update()
    {
        // --- Ensure offset always has the correct radius ---
        offset = offset.normalized * radius;

        // 1. Rotate the offset vector around Z-axis using quaternion
        Quaternion rotation = Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.forward);
        offset = rotation * offset;

        // 2. Update the object's position based on rotated offset
        transform.position = target.position + offset;

        // 3. Make the object face the target + extra 90° rotation
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + zRotationOffset);
    }
}

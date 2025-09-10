using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] public Vector3 Direction;
    [SerializeField] float MoveSpeedAmplifier = 1f;
    
    private void Start()
    {

    }

    
    private void Update()
    {
        Direction.x = Input.GetAxis("Horizontal");
        Direction.y = Input.GetAxis("Vertical");

        Direction = Direction.normalized;

        transform.position += Direction * Time.deltaTime * MoveSpeedAmplifier; 
    }



}

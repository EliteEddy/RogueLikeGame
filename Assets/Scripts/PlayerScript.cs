using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Vector3 Direction;
    [SerializeField] int MoveSpeedAmplifier = 1;

    private void Start()
    {

    }

    
    private void Update()
    {
        Direction.x = Input.GetAxis("Horizontal");
        Direction.y = Input.GetAxis("Vertical");

        transform.position += Direction * Time.deltaTime * MoveSpeedAmplifier; 
    }



}

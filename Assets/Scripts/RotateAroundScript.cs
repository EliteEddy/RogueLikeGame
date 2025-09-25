using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 200f;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 uniqueAxis =  new Vector3(0, 0, 1);
    
    void Start()
    {
     
    }
     void Update()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;

        transform.RotateAround(target.position, uniqueAxis, rotationAmount);

    }

     private float CalculateRotationAmount()
    {
        return  0f;
    }


}
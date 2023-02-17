using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    private float _speed;
    private Vector3 _movementForce = new Vector3(0, 0, 1);
    
    private void FixedUpdate()
    {
        transform.Translate(_movementForce * _speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 direction;
    private  Rigidbody2D rigidbody;
    [SerializeField] private float speed;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();  
    }
    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position+direction*speed*Time.fixedDeltaTime);
    }
    private void OnMove(InputValue value)
    {
        direction=value.Get<Vector2>();

    }
}

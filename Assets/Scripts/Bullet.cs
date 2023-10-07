using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 500f;
    public float maxLifeTime = 10f;
    private  Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    public void project(Vector2 direction)
    {
        rigidbody.AddForce(direction*speed*Time.deltaTime);
        Destroy(gameObject,maxLifeTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }

}

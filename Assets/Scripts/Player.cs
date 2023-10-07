using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isDead = false;
    public Bullet bulletPrefab;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isDead = true;
            Destroy(gameObject);
            GameManager.instance.ResetLevel();
        }
    }
    private void Shoot()
    {
        Bullet bullet=Instantiate(bulletPrefab,transform.position,transform.rotation);
        bullet.project(transform.up);
    }
}

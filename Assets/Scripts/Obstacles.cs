using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float lives=1;
     public bool isDead;
    private void Awake()
    {
        rigidbody = GetComponentInParent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            lives--;
            if(lives == 0)
            {
                isDead = true;  
                Destroy(gameObject);
                GameManager.instance.IncreaseScore();               
                UIManager.instance.WriteScore();
            }
        }
    }
}

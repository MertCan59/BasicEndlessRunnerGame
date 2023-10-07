using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        transform.position += Vector3.down* speed * Time.deltaTime;
   }
}

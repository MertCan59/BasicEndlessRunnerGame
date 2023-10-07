using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacles;
    public Player player;
    private void Start()
    {
        StartCoroutine(SpawnObject());
    }
    private IEnumerator SpawnObject()
    {
        while(!player.isDead)
        {
            Instantiate(obstacles, new Vector3(Random.Range(0f,7.5f),0.75f, 0f), Quaternion.identity);
            Instantiate(obstacles, new Vector3(Random.Range(-4f,0f),0.75f, 0f), Quaternion.identity);
            yield return new  WaitForSeconds(0.3f);
        }
    }
}

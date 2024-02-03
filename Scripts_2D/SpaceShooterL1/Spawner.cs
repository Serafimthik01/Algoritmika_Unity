using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public Transform borderRight;
    public Transform borderLeft;

    public float spawnInterval;
    public float spawnTimer;

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            Spawn();
        }
    }

    void Spawn()
    {

        float randomX = Random.Range(borderLeft.position.x, borderRight.position.x);

        Vector2 newPosition = transform.position;
        newPosition.x = randomX;

        Instantiate(prefab, newPosition, Quaternion.identity);
        spawnTimer = spawnInterval;
    }

}

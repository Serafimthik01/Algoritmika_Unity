using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy enemyPrefab;

    public Transform topBorder;
    public Transform bottomBorder;

    public float spawnInterval = 1f;
    public float spawnTimer = 0f;

    public float spawnIntervalMax = 3.5f;
    public float spawnIntervalMin = 1f;

    public int spawnCounter = 10;

    public int spawnAddPerLevel = 5;

    private void Start()
    {
        spawnCounter += spawnAddPerLevel * GameController.level;
    }

    public void Spawn()
    {
        spawnCounter--;

        spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);

        Vector2 randomPosition = new Vector2(this.transform.position.x, Random.Range(topBorder.position.y, bottomBorder.position.y));

        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }

    void Update()
    {
        if (LevelController.finished == false)
        {
            if (spawnTimer > 0)
            {
                spawnTimer -= Time.deltaTime;
            }
            else if (spawnCounter > 0)
            {
                Spawn();
            }
        }
    }
}
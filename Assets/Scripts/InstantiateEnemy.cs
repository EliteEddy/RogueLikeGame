using UnityEngine;
using UnityEngine.Tilemaps;

public class InstantiateEnemy : MonoBehaviour
{
    public GameObject Prefab;
    public float spawnInterval = 1f;
    public Tilemap groundTilemap;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            TrySpawnEnemy();
            timer = 0f;
        }
    }

    void TrySpawnEnemy()
    {
        // Convert spawner's world position into cell position on the tilemap

        Vector3Int cell = groundTilemap.WorldToCell(transform.position);

        // Check if there is a ground tile here
        if (groundTilemap.HasTile(cell))
        {
            Instantiate(Prefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("Spawner is not on a Ground tile, no enemy spawned.");
        }
    }
}


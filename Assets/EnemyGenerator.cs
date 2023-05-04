using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private List<EnemyStats> enemies;

    [SerializeField]
    private GameObject enemyPrefab;

    [Range(0.01f, 10f)]
    [SerializeField]
    private float delay = 1f;

    [Range(0.01f, 10f)]
    [SerializeField]
    private float range = 1f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0, delay);
    }

    private void SpawnEnemy()
    {
        var randomArea = Random.insideUnitCircle * range;
        var transformPosition = transform.position;

        var spawnPosition = new Vector3(
            transformPosition.x + randomArea.x,
            transformPosition.y + randomArea.y,
            transformPosition.z
        );

        var enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        var enemyController = enemy.GetComponent<EnemyController>();
        var enemyStats = enemies[Random.Range(0, enemies.Count)];
        enemyController.SetStats(enemyStats);
    }
}

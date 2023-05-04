using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private HealthSystem healthSystem;

    public void SetStats(EnemyStats enemy)
    {
        healthSystem.SetStats(enemy.maxHealth);
    }
}

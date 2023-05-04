using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "ScriptableObjects/EnemyStats", order = 1)]
public class EnemyStats : ScriptableObject
{
    public float maxHealth;
    public float attackRange;
    public float attackCooldown;
    public GameObject projectilePrefab;

    public void SetStats(float health, float range, float cooldown, GameObject projectile)
    {
        maxHealth = health;
        attackRange = range;
        attackCooldown = cooldown;
        projectilePrefab = projectile;
    }
}

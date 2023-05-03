using UnityEngine;

public class ProjectileAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;

    [Range(1f, 50f)]
    [SerializeField]
    private float attackSpeed;

    [Range(0.1f, 10f)]
    [SerializeField]
    private float attackCooldown;

    private float _nextAttackTime;

    public void TryAttack(Vector3 targetPosition)
    {
        if (Time.time < _nextAttackTime)
        {
            return;
        }

        ShootProjectile(targetPosition, gameObject);
        _nextAttackTime = Time.time + attackCooldown;
    }

    private void ShootProjectile(Vector3 targetPosition, GameObject shooter)
    {
        var transformPosition = transform.position;
        var direction = (targetPosition - transformPosition).normalized;
        var projectile = Instantiate(projectilePrefab, transformPosition, Quaternion.identity);

        var projectileScript = projectile.GetComponent<Projectile>();
        projectileScript.Shoot(direction * attackSpeed, shooter);
    }
}

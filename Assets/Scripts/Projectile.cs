using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(1f, 100f)]
    [SerializeField]
    private float damage = 10f;

    [Range(0.1f, 10f)]
    [SerializeField]
    private float lifeTime = 3f;

    [SerializeField]
    private Rigidbody2D rb;

    private GameObject _shooter;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject == _shooter)
        {
            return;
        }

        var targetHealth = coll.GetComponent<HealthSystem>();

        if (targetHealth != null)
        {
            targetHealth.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

    public void Shoot(Vector3 velocity, GameObject shooter)
    {
        rb.velocity = velocity;

        _shooter = shooter;
    }
}

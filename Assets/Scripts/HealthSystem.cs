using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour
{
    [Range(10f, 50f)]
    [SerializeField]
    private float maxHealth = 20f;

    private float _currentHealth;

    public UnityEvent onDeath;

    private void Start()
    {
        _currentHealth = maxHealth;

        onDeath.AddListener(() => Destroy(gameObject));
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            onDeath.Invoke();
        }
    }
}

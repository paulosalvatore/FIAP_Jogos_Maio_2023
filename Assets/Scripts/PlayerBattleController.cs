using UnityEngine;

public class PlayerBattleController : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;

    private void Start()
    {
        InvokeRepeating(nameof(Attack), 0, 0.1f);
    }

    private void Attack()
    {
        var targetPosition = playerController.transform.position + Vector3.right * 10;

        playerController.ProjectileAttack.TryAttack(targetPosition);
    }
}

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
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var targetPosition = new Vector3(mousePosition.x, mousePosition.y, 0);

        playerController.ProjectileAttack.TryAttack(targetPosition);
    }
}

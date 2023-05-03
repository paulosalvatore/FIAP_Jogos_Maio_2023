using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private ProjectileAttack projectileAttack;

    public ProjectileAttack ProjectileAttack => projectileAttack;
}

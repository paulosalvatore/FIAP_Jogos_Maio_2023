using System;
using UnityEngine;

public class FixOrderInLayer : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Update()
    {
        UpdateOrderInLayer();
    }

    private void UpdateOrderInLayer()
    {
        spriteRenderer.sortingOrder = Mathf.RoundToInt(-transform.position.y * 100);
    }

    private void OnDrawGizmos()
    {
        UpdateOrderInLayer();
    }
}

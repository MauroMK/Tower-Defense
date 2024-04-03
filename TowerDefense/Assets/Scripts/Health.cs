using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int hitpoints = 2;

    public void TakeDamage(int damage)
    {
        hitpoints -= damage;

        if (hitpoints <= 0)
        {
            EnemySpawner.onEnemyDestroy.Invoke();
            Destroy(this.gameObject);
        }
    }
}

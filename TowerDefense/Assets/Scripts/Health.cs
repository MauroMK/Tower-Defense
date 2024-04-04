using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int hitpoints = 2;
    [SerializeField] private int goldValue = 50;

    private bool isDestroyed = false;

    public void TakeDamage(int damage)
    {
        hitpoints -= damage;

        if (hitpoints <= 0 && !isDestroyed)
        {
            EnemySpawner.onEnemyDestroy.Invoke();
            LevelManager.instance.IncreaseCurrency(goldValue);
            isDestroyed = true;
            Destroy(this.gameObject);
        }
    }
}

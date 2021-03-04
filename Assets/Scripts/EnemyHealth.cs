using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float hitpoints = 100f;

    //create public mtehod reducing hitpoints by amount of dmg.
    public void TakeDamage(float damage)
    {
        hitpoints -= damage;
        Debug.Log("enemy health: " + hitpoints);

        if (hitpoints <= 0)
        {
            Debug.Log("enemy died");
            Destroy(this.gameObject);
        }

    }
}

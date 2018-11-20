using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] private float health;

    public float Health
    {
        get
        {
            return health;
        }
    }

    public void GetDamaged(float damage)
    {
        health -= damage;
        Debug.Log("Player damaged!! health is now " + health);
    }

    private void Update()
    {
        if (health <= 0)
            gameObject.SetActive(false);
    }
}

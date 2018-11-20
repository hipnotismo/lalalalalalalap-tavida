using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour {

    [SerializeField] GameObject[] barrs;
    [SerializeField] private float totalHealth;
    float health;
    float lifes;
    int pos;

    private void Awake()
    {
        health = totalHealth;
        lifes = totalHealth / 3;
    }

    void Update ()
    {
        if (barrs[0].activeInHierarchy)
        {
            if (health <= totalHealth - lifes)
                barrs[0].SetActive(false);
        }
        else if (barrs[1].activeInHierarchy)
        {
            if (health <= totalHealth - lifes * 2)
                barrs[1].SetActive(false);
        }
        else if (barrs[2].activeInHierarchy)
        {
            if (health <= totalHealth - lifes * 3)
                barrs[2].SetActive(false);
        }
        else
            gameObject.SetActive(false);
	}

    public void GetDamage(float damage)
    {
        health -= damage;
        Debug.Log("Block's health is now " + health);
    }

}

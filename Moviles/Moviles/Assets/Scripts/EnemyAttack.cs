using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private float attackRate;
    [SerializeField] private float damage;
    private float timer;

    private void Awake()
    {
        timer = attackRate;
    }

    void Update ()
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, range);
        Debug.DrawRay(transform.position, transform.forward * range, Color.red);

        if (timer <= 0)
        {
            if (hit)
            {
                if (hitInfo.transform.CompareTag("Block"))
                    hitInfo.transform.GetComponent<BlockBehaviour>().GetDamage(damage);
                if (hitInfo.transform.CompareTag("Player"))
                    hitInfo.transform.GetComponent<PlayerHealth>().GetDamaged(damage);
            }

            timer = attackRate;
        }
        else
            timer -= Time.deltaTime;
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyShoot : MonoBehaviour {

    [SerializeField] private float damage;
    [SerializeField] private LayerMask isEnemy;

    void Update ()
    {
        bool shooting = Input.GetKeyDown(KeyCode.Mouse0);
        RaycastHit hitInfo; 
        Physics.Raycast(transform.position, transform.forward, out hitInfo, Mathf.Infinity, isEnemy);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.red);

        if (shooting)
        {
            if (hitInfo.transform.CompareTag("Enemy"))
                Destroy(hitInfo.transform.gameObject);
        }
	}
}

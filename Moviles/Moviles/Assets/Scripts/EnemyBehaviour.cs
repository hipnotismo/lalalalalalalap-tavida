using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour {

    private NavMeshAgent nav;
    private GameData gd;

    private void Awake()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
        gd = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameData>();
    }
    
    void Update ()
    {
        nav.SetDestination(gd.PlyPos);
	}
}

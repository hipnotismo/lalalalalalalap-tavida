using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

    [SerializeField] private GameObject player;
    private float plyHealth;
    private Vector3 plyPos;

    public Vector3 PlyPos
    {
        get
        {
            return plyPos;
        }
    }

    public float PlyHealth
    {
        get
        {
            return plyHealth;
        }
    }

    void Awake ()
    {
        plyPos = player.transform.position;
        plyHealth = player.GetComponent<PlayerHealth>().Health;
	}

    private void Update()
    {
        if (plyPos != player.transform.position)
            plyPos = player.transform.position;
        if(plyHealth != player.GetComponent<PlayerHealth>().Health)
            plyHealth = player.GetComponent<PlayerHealth>().Health;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    private float timer;
    [SerializeField] private float spawnRate;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject prefab;

    private void Awake()
    {
        timer = spawnRate;
    }

    private void SelectSpawn()
    {
        int i = UnityEngine.Random.Range(1, spawnPoints.Length);
        Instantiate(prefab, spawnPoints[i].position, Quaternion.identity);
        Debug.Log("point" + i + " selected");
    }

    void Update ()
    {
        if (timer <= 0)
        {
            SelectSpawn();
            timer = spawnRate;
        }

        timer -= Time.deltaTime;
	}
}

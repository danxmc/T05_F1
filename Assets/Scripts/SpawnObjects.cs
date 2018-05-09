using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public GameObject blockPrefab;

    public Transform player;

    public Vector3 center;
    public Vector3 size;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 15; i++) {
            SpawnBlocks();
        }
	}

    public void SpawnBlocks()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z /2 , size.z/2));
        Instantiate(blockPrefab, pos, Quaternion.identity);

    }

	void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTower : MonoBehaviour {

    [SerializeField]
    private GameObject towerHolder;
	// Use this for initialization
	void Start () {
        StartCoroutine(Spawner());
	}
	
	IEnumerator Spawner()
    {
        yield return new WaitForSeconds(2);
        Vector3 temp = towerHolder.transform.position;
        Instantiate(towerHolder, transform.position, Quaternion.identity);
        StartCoroutine(Spawner());
    }
}

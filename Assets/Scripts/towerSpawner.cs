using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerSpawner : MonoBehaviour {

    [SerializeField]

    private GameObject towerHolder;
	// Use this for initialization
	void Start () {
        StartCoroutine(Spawner());
	}
	
	IEnumerator Spawner()
    {
        yield return new WaitForSeconds(1);
        Instantiate(towerHolder, transform.position, Quaternion.identity);
        StartCoroutine(Spawner());
    }
}

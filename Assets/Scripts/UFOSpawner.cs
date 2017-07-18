using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawner : MonoBehaviour {

    [SerializeField]

    private GameObject UFO;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(3);

        Instantiate(UFO, transform.position, Quaternion.identity);
        StartCoroutine(Spawner());
    }
}

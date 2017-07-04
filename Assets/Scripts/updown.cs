using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{


    private Vector3 MovingDirection = Vector3.up;
    public float Uplimit = 3.0F;
    public float Downlimit = -3.0F;
    public float MovementSpeed = 2.0F;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(MovingDirection * Time.deltaTime * MovementSpeed);

        if (gameObject.transform.position.y > Uplimit)
        {
            MovingDirection = Vector3.down;
        }
        else if (gameObject.transform.position.y < Downlimit)
        {
            MovingDirection = Vector3.up;
        }
    }
}
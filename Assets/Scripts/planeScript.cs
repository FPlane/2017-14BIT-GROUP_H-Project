using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// to call the Button()
using UnityEngine.UI;

public class planeScript : MonoBehaviour {

    public static planeScript instance; // used to access each public variable that has been declared

    [SerializeField] // to show this variable on the unity inspector
    private Rigidbody2D myRigidBody;

    [SerializeField]
    private Animator anim; // to play animation of the plane
    private float forwardSpeed = 3f; // speed of the plane that fly in the forward direction
    private float boundSpeed = 4f; // speed of the plane that bounce up
    private bool didFlap; 
    public bool isAlive;

    private Button flapButton;

    void Awake()
    {
        // if script isn't point to is instance
        if(instance == null)
        {
            instance = this; // the birdscript is the instance
        }
        isAlive = true;

        flapButton = GameObject.FindGameObjectWithTag("FlapButton").GetComponent<Button>();
        flapButton.onClick.AddListener(() => FlapThePlane());
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () { // update every 2 or 3 frames
        if (isAlive) // if plane is alive, we can animate it
        {
            Vector3 temp = transform.position; // get the current position of the plane
            temp.x = temp.x + forwardSpeed * Time.deltaTime; // move the plane to the right
            transform.position = temp; // re-assign the plane's position 

            if(didFlap) 
            {
                didFlap = false; // flap once
                myRigidBody.velocity = new Vector2(0, boundSpeed); // (0, 4f)
                anim.SetTrigger("Flap"); // setTriggner of the Animator
            }
        }
	}

    void setCameraX()
    {
        cameraScript.offsetX = (Camera.main.transform.position.x - transform.position.x) - 1f;
    }

    public float GetPositionX()
    {
        return transform.position.x;
    }

    public void FlapThePlane()
    {
        didFlap = true; 

    }


}

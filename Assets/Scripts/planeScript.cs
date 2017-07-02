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

    [SerializeField]
    private float forwardSpeed; // speed of the plane that fly in the forward direction
    [SerializeField]
    private float boundSpeed; // speed of the plane that bounce up
    public bool didFlap; 
    public bool isAlive;

    private Button flapButton;

    public int proneUp;
    public int proneDown;

    public float flapFuel;

    [SerializeField]
    private AudioSource audiosource;

    [SerializeField]
    private AudioClip flapClip, diedClip, scoreClip;


    private GameObject[] fuelDrop;
    private GameObject Drop;
    private int distance = 10;
    private float lastDropX;
    private float DropMaxHeight = 5f;
    private float DropMinHeight = -5f;

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
        Time.timeScale = 1.0f;
        setCameraX();

        fuelDrop = GameObject.FindGameObjectsWithTag("FuelDrop");
        for (int i = 0; i < fuelDrop.Length; i++)
        {
            Vector3 temp = fuelDrop[i].transform.position;
            temp.y = Random.Range(DropMinHeight, DropMaxHeight);
            fuelDrop[i].transform.position = temp;
        }

        lastDropX = fuelDrop[0].transform.position.x;

        for (int i = 1; i < fuelDrop.Length; i++)
        {
            if (lastDropX < fuelDrop[i].transform.position.x)
            {
                lastDropX = fuelDrop[i].transform.position.x;
            }
        }
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
                audiosource.PlayOneShot(flapClip);
                anim.SetTrigger("Flap"); // setTriggner of the Animator

                //if(fuel.instance != null)
                //{
                //    flapFuel = fuel.instance.planeFuel -= 10f;
                //}
            }

            if (myRigidBody.velocity.y >= 0) // make rotation for the plane
            {
                //transform.rotation = Quaternion.Euler(0, 0, 0);
                float angle = 0;
                angle = Mathf.Lerp(0, proneUp, myRigidBody.velocity.y / 7); // prone up 45 degree
                transform.rotation = Quaternion.Euler(0, 0, angle);
            }
            else
            {
                float angle = 0;
                angle = Mathf.Lerp(0, -proneDown, -myRigidBody.velocity.y / 7); // prone down 45 degree
                transform.rotation = Quaternion.Euler(0, 0, angle);
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

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ground")
        {
            if (isAlive)
            {
                isAlive = false;

                // freeze game - prevent plane fuel keep 
                Time.timeScale = 0.0f;
                Destroy(flapButton);
                audiosource.PlayOneShot(diedClip);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "FuelDrop")
        {


            Vector3 temp = target.transform.position;
            temp.x = lastDropX + distance;
            temp.y = Random.Range(DropMinHeight, DropMaxHeight);
            target.transform.position = temp;
            lastDropX = temp.x;
        }
    }

}

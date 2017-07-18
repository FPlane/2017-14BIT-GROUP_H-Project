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

    [SerializeField]
    private AudioClip itemClip;


    //// Fuel collector
    //private GameObject[] fuelDrop;
    //private GameObject Drop;
    //public int distance;
    //private float lastDropX;
    //public float DropMaxHeight;
    //public float DropMinHeight;
    //public int flewDistance;
    ////


    public Text distanceText;
    public float currentDistance;

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


            // Flight distance
            currentDistance += Time.deltaTime*10;
            
            distanceText.text = currentDistance.ToString("F0") + " m"; // Sua cho nay F1 thanh 0
            // add this to the pause panel


            if (didFlap) 
            {

                didFlap = false; // flap once
                myRigidBody.velocity = new Vector2(0, boundSpeed); // (0, 4f)
                audiosource.PlayOneShot(flapClip);
                anim.SetTrigger("Flap"); // setTriggner of the 
                if(fuel.instance != null)
                {
                    fuel.instance.planeFuel -= fuel.instance.fuelBurn * flapFuel;
                }
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
        // if plane hit the ground or the pipes, run this codes
        if (target.gameObject.tag == "Ground" || target.gameObject.tag == "UFO" || target.gameObject.tag == "Pipe")
        {
            if (isAlive)
            {
                isAlive = false;

                // freeze game - prevent plane fuel keep 
                //Time.timeScale = 0;
                Destroy(flapButton);
                audiosource.PlayOneShot(diedClip);

                if(gamePlayMananger.instance != null)
                {
                    gamePlayMananger.instance.hidePauseButton();
                    gamePlayMananger.instance.showGameOverPanel();
                }

               
           
            }
        }

        //if (target.gameObject.tag == "Pipe")
        //{
        //    if (isAlive)
        //    {
        //        isAlive = false;

        //        // freeze game - prevent plane fuel keep 
        //        Time.timeScale = 0.0f;
        //        Destroy(flapButton);
       
        //        audiosource.PlayOneShot(diedClip);
        //    }
        //}
    }

    void OnTriggerEnter2D(Collider2D target)
    {

        //if (target.tag == "PipeHolder")
        //{
        //    audiosource.PlayOneShot(scoreClip);
        //}

        if (target.tag == "Pipe")
        {
            audiosource.PlayOneShot(itemClip);
            
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
	Transform tr;
	Rigidbody rb;
	public char listenKey;

	//public Transform CameraRig;              // Variable to reference position, rotation, and scale of camera rig object, we will use this for grabbing position to spawn objects.
	//public GameObject keyObject;
    public Rigidbody keyObject;
    public int rotationTransform = 0;

	//public float MoveSpeed = 1;
	public float speed = 3.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3 (0.0f, 0.0f, -0.5f);
	}
	
	// Update is called once per fixed period of time
	void Update () {
//		if (Input.GetKey (listenKey.ToString()))
//			Debug.Log("Triggered this key object: " + listenKey);

	}
	void spawn(){
	}
	public void setLetter(char letter){
		listenKey = letter;
	}
    public char getLetter()
    {
        return listenKey;
    }
}

using UnityEngine;
using System.Collections;

public class BallContoller : MonoBehaviour {

    float speed = 20.0F;

	// Use this for initialization
	void Start () {
        rigidbody.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

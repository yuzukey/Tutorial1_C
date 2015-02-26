using UnityEngine;
using System.Collections;

public class RacketController : MonoBehaviour
{

    float Accel = 1000.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        rigidbody.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * Accel, ForceMode.Impulse);
	}
}

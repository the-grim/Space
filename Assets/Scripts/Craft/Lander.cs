using UnityEngine;
using System.Collections;

public class Lander : MonoBehaviour {
	
	public Vector3 propulsionForce;
	public Vector3 rotationForce;
	
	// Use this for initialization
	void Start() {
	
	}
	
	void FixedUpdate() {
		
		if(Input.GetButton("Vertical")){
			rigidbody.AddRelativeForce(propulsionForce, ForceMode.Impulse);
		}
		if(Input.GetButton("Horizontal")){
			rigidbody.AddTorque(Input.GetAxis("Horizontal") * -rotationForce, ForceMode.Impulse);
		}
		if (Input.GetButton ("Lateral")){
			rigidbody.AddTorque (Input.GetAxis("Lateral") * -rotationForce, ForceMode.Impulse);
		}
		}
	// Update is called once per frame
	void Update() {
	
		
	}
}

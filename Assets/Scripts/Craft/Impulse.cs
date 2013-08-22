using UnityEngine;
using System.Collections;

public class Impulse : MonoBehaviour {
	
	public Vector3 propulsionForce;
	public string useKey;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate (){
	
		if(Input.GetKey(useKey)){
			rigidbody.AddRelativeForce (propulsionForce);	
		}		
	}	
}

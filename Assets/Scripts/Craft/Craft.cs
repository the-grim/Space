using UnityEngine;

public class Craft : MonoBehaviour {
	
	public static float distanceTraveled;
	public float acceleration;
	public Vector3 jumpVelocity;
	
	private bool touchingPlatform;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(touchingPlatform && Input.GetButtonDown("Jump")){
			rigidbody.AddForce (jumpVelocity, ForceMode.VelocityChange);
		}
		
		distanceTraveled = transform.localPosition.x;
	}
	void FixedUpdate(){
		if(touchingPlatform){
				rigidbody.AddForce(acceleration, 0f, 0f, ForceMode.Acceleration);
		}
	}	
	void OnCollisionEnter(){
			touchingPlatform = true;
	}
	
	void OnCollisionExit(){
			touchingPlatform = false;
	}
		
}

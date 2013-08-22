using UnityEngine; //Using the main Unity library
using System.Collections;

public class GravityBody : MonoBehaviour { //the class is called GravityBody (must be same as the script file name)
	
	public float mass; //These parameters are visible in the parameters of any GameObject using this script
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void Update() {
	
	}
	
	void FixedUpdate () { //FixedUpdate is called once every physics cycle independent of framerate - put all physics calculations here instead of Update
	
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Craft"); //Finding every GameObject in the scene that has a tag "Craft" and storing them in a list called "targets"
		
		foreach(GameObject obj in targets) { //Going through the list "targets", storing the current item in "obj" and running the Attract method for each of them
				Attract (obj);
			}
		
	}

	void Attract (GameObject obj) { //Attraction calculations
	
		Vector3 gravityDir = (this.transform.position - obj.transform.position);  //The direction vector from the GravityBody to the attracted object
		
		obj.rigidbody.AddForce (WorldManager.G * gravityDir.normalized * mass * obj.rigidbody.mass / Mathf.Pow(gravityDir.magnitude, 2));  //Gravity force calculation based on masses
		
	} 

}

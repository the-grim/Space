using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	//Camera follows X and Y coordinates of a specified GameObject
	
	public GameObject target;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	var oldPos = transform.position;	//storing the original Z position to a new variable
	transform.position = new Vector3(target.transform.position.x, target.transform.position.y, oldPos.z); //need to set the whole transform.position, individual components can't be set
	
	}
}

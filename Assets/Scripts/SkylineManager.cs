using UnityEngine;
using System.Collections.Generic;

public class SkylineManager : MonoBehaviour {

	public Transform prefab;
	public int numberOfObjects;
	public float recycleOffset;
	public Vector3 minSize, maxSize;
	
	private Vector3 nextPosition;
	private Queue<Transform> objectQueue;
	
	// Use this for initialization
	void Start () {
		objectQueue = new Queue<Transform>(numberOfObjects);
			for(int i = 0; i < numberOfObjects; i++){
			objectQueue.Enqueue((Transform)Instantiate (prefab));
		}	
		nextPosition = transform.localPosition;	
		for(int i = 0; i < numberOfObjects; i++){;
			Recycle ();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if(objectQueue.Peek ().localPosition.x + recycleOffset < Craft.distanceTraveled){
			Recycle ();
		}
	}
	
	private void Recycle() {
		Vector3 scale = new Vector3(
			Random.Range(minSize.x, maxSize.x),
			Random.Range(minSize.y, maxSize.y),
			Random.Range(minSize.z, maxSize.z));
		
		Vector3 position = nextPosition;
		position.x += scale.x * 0.5f;
		position.y += scale.y * 0.5f;
			
		Transform box = objectQueue.Dequeue();
		box.localScale = scale;
		box.localPosition = position;
		nextPosition.x += box.localScale.x;
		objectQueue.Enqueue(box);
	}

}

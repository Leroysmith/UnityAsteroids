using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	public float speed = 10;
	Vector2 moveDirection;
	
void Start(){
 
	transform.Rotate (0, Random.Range(-180, 180), 0);
			
			
			
}
	void Update(){
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0,0,200));
	}
	
}
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speedF;
	public float speedB;
	bool fire = false;
	
	
	//public float playerSpeed = 12.0f;
	//public float rotationSpeed = 20.0f;
	
	// Use this for initialization
	void Start () {
		
		//Player spawn point
		
		//player == game object. Game object == transform.
		transform.position = new Vector3(0, 1, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		// player to move left/ right/ up/ down
		//player (Gameobject) aka transform move with arrow keys.
		
		//rigidbody.AddForce(Vector3.right * Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
	
		//transform.Translate(Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
		
		//transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
			
		
		if(Input.GetKey(KeyCode.W))
  		{
  		 	rigidbody.AddRelativeForce(new Vector3(0,0,speedF));
  		}
  		
		if(Input.GetKey(KeyCode.S))
  		{
  			 rigidbody.AddRelativeForce(new Vector3(0,0,speedB));
 		}
		
  		if(Input.GetKey(KeyCode.A))
  		{
  			 transform.Rotate(new Vector3(0,-10,0)); 
 		}
 
		if(Input.GetKey(KeyCode.D))
		 {
  			 transform.Rotate(new Vector3(0,10,0)); 
 		 }
		
		if(Input.GetAxis("Fire1")== 1)
		{
			if (fire == false)
				{	
					fire = true;
					GameObject bullet = Instantiate(Resources.Load ("Bullet"), transform.position, transform.rotation) as GameObject;
				}
		}
		
		
			else
		{
				
			fire = false;
		}
	}
	
		void OnCollisionEnter(Collision col)
	{

		if (col.collider.name == "Asteroid")
		{
			Application.LoadLevel (0);
		}
	}
}

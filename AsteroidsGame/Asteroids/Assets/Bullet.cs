using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float speed;
	
	/*public Rigidbody bullet;
	
	bool fire = false;
	*/
	// Use this for initialization
	void Start () {
		
		Destroy(gameObject, 1.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0, 0, speed));
	
		
		/*if(Input.GetAxis("Fire1") == 1){
		Debug.Log("schiet");
		if(fire == false){
				fire = true;
				
				Rigidbody clone;
				clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection(Vector3.up * 10);
		}		
			
		}
		
				else 
			{
				fire = false;
			}
			
			*/
		
		
		
	}
	
	void OnTriggerEnter(Collider col)
 	{
  	if (col.collider.name == "Asteroid")
			Destroy(col.gameObject);
	
			
	}	

}

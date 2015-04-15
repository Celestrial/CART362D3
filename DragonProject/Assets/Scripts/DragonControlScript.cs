using UnityEngine;
using System.Collections;

public class DragonControlScript : MonoBehaviour {
	Vector3 startLook;
	const int MAX_VERT_ROT = 60;
	public float velocity = .02f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			transform.Rotate(Vector3.right, MAX_VERT_ROT * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Rotate(Vector3.right, -MAX_VERT_ROT * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.forward, MAX_VERT_ROT * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.forward, -MAX_VERT_ROT * Time.deltaTime);
		}
		transform.position += transform.forward * velocity;
	}
}

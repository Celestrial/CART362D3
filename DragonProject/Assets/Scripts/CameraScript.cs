using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public GameObject Dragon;
	//Transform startPosition;
	//Transform currentPosition;
	public Vector3 offset;
	public Vector3 lookOffset;

	// Use this for initialization
	void Start () {
		transform.position = Dragon.transform.position + offset;
		transform.LookAt(Dragon.transform.position + lookOffset);
//		startPosition = transform;
//		currentPosition = transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = Vector3.zero;
		temp += Dragon.transform.up  * offset.y;
		temp += Dragon.transform.forward * offset.z;
		transform.position = Dragon.transform.position + temp;
//		transform.position = Dragon.transform.position + Dragon.transform.right * offset.x;
//		transform.position = Dragon.transform.position + Dragon.transform.up * offset.y;
//		transform.position = Dragon.transform.position + transform.forward *offset.z;


		//transform.LookAt(Dragon.transform.position + lookOffset);
	}
}

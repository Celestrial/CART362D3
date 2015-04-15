using UnityEngine;
using System.Collections;

public class ParticleCollisions : MonoBehaviour {
	public GameObject fire;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnParticleCollision(GameObject other)
	{
		Instantiate(fire);
	}
}

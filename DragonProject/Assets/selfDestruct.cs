using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {
	public float timer = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(timer > 0)
			timer -= Time.deltaTime;
		else
			Destroy (gameObject);
	}
}

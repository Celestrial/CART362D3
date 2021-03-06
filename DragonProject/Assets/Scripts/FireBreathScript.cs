﻿using UnityEngine;
using System.Collections;

public class FireBreathScript : MonoBehaviour {
	Animation actions;
	public GameObject fire;
	public GameObject gums;
	float fireControl = 0;
	GameObject fireBreath = null;
	// Use this for initialization
	void Start () {
		actions = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1") && fireControl > .5)
		{
			fireBreath = (GameObject)Instantiate(fire, gums.transform.position, transform.rotation);
			actions.Play("FireGlide");
			fireControl = 0;
		}
		if(!actions.isPlaying)
		{
			actions.Rewind();
			actions.Play("Flying");
		}
		if(fireBreath != null)
			fireBreath.transform.position = GameObject.Find("FireOut").transform.position;

		fireControl+= Time.deltaTime;
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativeMovement : MonoBehaviour {
	
	[SerializeField] private Transform _target;  
	public float rotSpeed = 15.0f; 
	
	void Update() {
		
		Vector3 movement = Vector3.zero;
		float horInput = Input.GetAxis("Horizontal");
		float vertInput = Input.GetAxis("Vertical");
		
		if (horInput != 0 || vertInput != 0) 
		{ 
			movement.x = horInput;
			movement.z = vertInput;
			Quaternion tmp = _target.rotation;
			_target.eulerAngles = new Vector3(0, _target.eulerAngles.y, 0);
			movement = _target.TransformDirection(movement);
			_target.rotation = tmp;
			Quaternion direction = Quaternion.LookRotation(movement);
			transform.rotation = Quaternion.Lerp(transform.rotation, direction, rotSpeed * Time.deltaTime);
		}  
	} 
} 
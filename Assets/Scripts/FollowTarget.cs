﻿using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
	public Transform target;
	public Vector3 offset = new Vector3(0f, 7.5f, 0f);

	
	void LateUpdate()
	{
		if (target == null) {
			target = GameObject.FindGameObjectWithTag ("Player").transform;	
		}
		transform.position = target.position + offset;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blip : MonoBehaviour
{
	public Transform Target;
	private MiniMap map;
	private RectTransform myRectTransform;
	//private GameObject _player;
	
	private void Start()
	{
		map = GetComponentInParent<MiniMap>();
		myRectTransform = GetComponent<RectTransform>();
	}

	void Update()
	{
		//Debug.Log(_player.transform.position);
	}

	void LateUpdate()
	{
		
		Vector2 newPosition = map.TransformPosition(Target.position);
		//Debug.Log(Target.position);
		myRectTransform.localPosition = newPosition;
	}
}

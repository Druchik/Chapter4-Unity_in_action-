using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blip2 : MonoBehaviour
{

	private MiniMap map;
	private RectTransform myRectTransform;
	private Lidar lidar;
	public Transform Target;
	
	private void Start()
	{
		map = GetComponentInParent<MiniMap>();
		myRectTransform = GetComponent<RectTransform>();
		lidar = GetComponent<Lidar>();
		//var script = gameObject.GetComponent(typeof(Lidar)) as Lidar;
		//points = lidar.points;
	}

	void Update()
	{
		//Debug.Log(_player.transform.position);
	}

	void LateUpdate()
	{
		int y = 3;
		int z = lidar.Check(y);
		Debug.Log(z);
		Vector3 newpoint = Target.position;
		//foreach (Vector3 x in lidar.points)
		//{
		//	Debug.Log(x);
		//}
		
		//Vector2 newPosition = map.TransformPosition(newpoint);
		//Debug.Log(newPosition);
		//myRectTransform.localPosition = newPosition;
	}
}
using System;
using UnityEngine;


// Object for storing all saved data in json
public class JSONdata
{

	public Vector3 position;
	public Quaternion rotation;
	public int scene;
	public int[] win;

	public JSONdata(Vector3 position, Quaternion rotation, int scene, int[] win)
	{
		this.position = position;
		this.rotation = rotation;
		this.scene = scene;
		this.win = win;
	}
}


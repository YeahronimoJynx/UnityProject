using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickEffect : MonoBehaviour
{
	//public delegate void IDEvent(int id);
	//public static event IDEvent MaterialSelected;
	public delegate void IDEvent(Material mat);
	public event IDEvent MaterialChanged;

	public delegate void TestEvent();
	public static event TestEvent Blubb;

	void OnMouseDown()
	{
		Debug.Log("clicked");
		//Blubb();
		//if(MaterialSelected != null) MaterialSelected(0);
		Material tempMat = GetComponent<MeshRenderer>().material;
		if (MaterialChanged != null) MaterialChanged(tempMat);
		//Debug.Log("blubb");
	}

	public void Initialize()
	{

	}
}

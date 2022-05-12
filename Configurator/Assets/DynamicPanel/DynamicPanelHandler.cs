using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DynamicPanelHandler : MonoBehaviour
{
	//public GameObject saveObj;
	private Transform parentTrans;
	RessourceLoader resLoader;
	public GameObject saveObj;

	//UnityEvent someEvent = new UnityEvent();

	private ClickEffect cEffect;
	int type = 0;
	int index = 0;
	// Start is called before the first frame update
	void Start()
	{
		resLoader = GetComponent<RessourceLoader>();
		parentTrans = gameObject.GetComponent<Transform>();
		GameObject tempSave = Instantiate(saveObj, parentTrans.position, parentTrans.rotation);
		tempSave.transform.SetParent(parentTrans);
		cEffect = tempSave.GetComponent<ClickEffect>();
		//cEffect.Initialize();
		//someEvent.AddListener(cEffect.MaterialChanged);
		cEffect.MaterialChanged += SetMaterial;
		//if (cEffect != null)
		//{
		//	Debug.Log("has cEffect script");
		//	cEffect.Blubb += WhatEver;
		//}
		//SetMaterial();
		//saveObj.GetComponent<ClickEffect>().Blubb += WhatEver;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void HandleLeftRightButtons(bool right)
	{
		if (right) type++;
		else index++;

		//SetMaterial();
	}

	void SetMaterial(Material mat)
	{
		Debug.Log("click und so");
		//Debug.Log(mat.name);
		//Material tempMat = resLoader.GetMaterial(type, index);
		//if (tempMat != null) tempSave.GetComponent<MeshRenderer>().material = tempMat;
		//else Debug.Log("index out of range, reset to 0 again");
	}

	public int GetSelectedID()
	{
		return 0;
	}
}

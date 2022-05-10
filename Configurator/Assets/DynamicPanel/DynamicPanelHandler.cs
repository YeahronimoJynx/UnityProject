using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicPanelHandler : MonoBehaviour
{
	public GameObject saveObj;
	private Transform parentTrans;
	RessourceLoader resLoader;
	GameObject tempSave;
	int type = 0;
	int index = 0;
	// Start is called before the first frame update
	void Start()
	{
		resLoader = GetComponent<RessourceLoader>();
		parentTrans = gameObject.GetComponent<Transform>();
		tempSave = Instantiate(saveObj, parentTrans.position, parentTrans.rotation);
		tempSave.transform.SetParent(parentTrans);
		SetMaterial();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void HandleLeftRightButtons(bool right)
	{
		if (right) type++;
		else index++;

		SetMaterial();
	}

	private void SetMaterial()
	{
		Material tempMat = resLoader.GetMaterial(type, index);
		if (tempMat != null) tempSave.GetComponent<MeshRenderer>().material = tempMat;
		else Debug.Log("index out of range, reset to 0 again");
	}

	public int GetSelectedID()
	{
		return 0;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleInteraction : MonoBehaviour
{
	public RessourceLoader resLoad;

	//public InteractableObject cube;
	//public InteractableObject cylinder;
	private GameObject currentBuilding;
	private GameObject currentEnvironment;
	private Transform trans;
	InteractableObject inter;
	// Start is called before the first frame update
	void Start()
	{
		trans = gameObject.transform;
		currentBuilding = Instantiate(resLoad.GetRandomHouse(), trans.position, trans.rotation);
		inter = currentBuilding.GetComponent<InteractableObject>();


		//Material tempMat = resLoad.GetMatByID(0);
		//Debug.Log("mat name: " + tempMat.name);
	}


	public void ChangeWall()
	{
		if (inter != null) inter.ChangeWall(resLoad.GetRandomMat());
	}

	public void ChangeRoof()
	{
		if (inter != null) inter.ChangeRoof(resLoad.GetRandomMat());
	}
	//public void ChangeCube()
	//{
	//	if (currentEnvironment != null) Destroy(currentEnvironment);

	//	currentEnvironment = Instantiate(resLoad.GetRandomEnvironment(), gameObject.transform.position, gameObject.transform.rotation);
	//	//int tempID = PlayerPrefs.GetInt("Cube");
	//	//cube.SetMaterial(resLoad.GetMatByID(tempID));
	//	//cube.SetMaterial(resLoad.GetRandomMat());
	//}


	//public void ChangeCylinder()
	//{
	//	int tempID = PlayerPrefs.GetInt("Cylinder");
	//	//cylinder.SetMaterial(resLoad.GetMatByID(tempID));
	//	cylinder.SetMaterial(resLoad.GetRandomMat());
	//}
}

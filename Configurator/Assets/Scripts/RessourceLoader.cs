using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceLoader : MonoBehaviour
{
	Object[] allMetalMats;
	Object[] allWoodMats;
	MeshRenderer render;
	int matID = 0;

	// Start is called before the first frame update
	void Start()
	{
		allMetalMats = Resources.LoadAll("MaterialsMetal", typeof(Material));
		allWoodMats = Resources.LoadAll("MaterialsWood", typeof(Material));
	}

	public Material GetMaterial(int typeID = 0, int indexID = 0)
	{
		switch(typeID)
		{
			case 0:
				return (Material)allMetalMats[indexID];
			case 1:
				return (Material)allWoodMats[indexID];
			default:
				return null;	
		}
	}
}

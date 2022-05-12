using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractableObject : MonoBehaviour
{
	int id;
	string name;
	public MeshRenderer renderWall;
	public MeshRenderer renderRoof;
	public MeshRenderer renderWindow;

	public void ChangeWall(Material mat)
	{
		renderWall.material = mat;
	}

	public void ChangeRoof(Material mat)
	{
		renderRoof.material = mat;
	}

	public void ChangeWindow(Material mat)
	{
		renderWindow.material = mat;
	}
}

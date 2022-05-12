using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceLoader : MonoBehaviour
{
	Object[] allMats;
	Object[] allSounds;
	Object[] allEnvironments;
	Object[] allHouses;

	// Start is called before the first frame update
	void Awake()
	{
		allMats = Resources.LoadAll("Materials", typeof(Material));
		allSounds = Resources.LoadAll("Sounds", typeof(AudioClip));
		allEnvironments = Resources.LoadAll("Environment", typeof(GameObject));
		allHouses = Resources.LoadAll("Houses", typeof(GameObject));

		Debug.Log("Materials: " + allMats.Length);
		//Debug.Log("Houses: " + allHouses.Length);
		//Debug.Log("Environments: " + allEnvironments.Length);
	}

	public Material GetRandomMat()
	{
		return (Material)allMats[Random.Range(0, allMats.Length)];
	}

	public Material GetMatByID(int id)
	{
		if (id >= allMats.Length)
		{
			Debug.LogWarning("index out of range");
			return (Material)allMats[0];

		}
		return (Material)allMats[id];
	}

	public AudioClip GetRandomSound()
	{
		return (AudioClip)allSounds[Random.Range(0, allSounds.Length)];
	}

	public AudioClip GetSoundByID(int id)
	{
		if (id >= allSounds.Length)
		{
			Debug.LogWarning("index out of range");
			return (AudioClip)allSounds[0];

		}
		return (AudioClip)allSounds[id];
	}

	public GameObject GetRandomEnvironment()
	{
		return (GameObject)allEnvironments[Random.Range(0, allEnvironments.Length)];
	}

	public GameObject GetEnvironmentByID(int id)
	{
		if(id >= allEnvironments.Length)
		{
			Debug.LogWarning("index out of range");
			return (GameObject)allEnvironments[0];
		}
		return (GameObject)allEnvironments[id];
	}

	public GameObject GetRandomHouse()
	{
		int tempID = Random.Range(0, allHouses.Length);
		return (GameObject)allHouses[tempID];
	}

	public GameObject GetHouseByID(int id)
	{
		if (id >= allHouses.Length)
		{
			Debug.LogWarning("index out of range");
			return (GameObject)allHouses[0];
		}
		return (GameObject)allHouses[id];
	}
}

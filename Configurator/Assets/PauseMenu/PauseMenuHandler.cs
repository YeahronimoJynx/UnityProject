using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuHandler : MonoBehaviour
{
	public GameObject ExitPanel;
    // Start is called before the first frame update
    void Start()
    {
       //ExitPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	public void ChangeResolution(int id)
	{
		//Debug.Log(id);
		//Debug.Log("id " + id + " selected");
		switch (id)
		{
			case 0:
				Screen.SetResolution(1024, 768, true);
				Debug.Log("1024");
				break;
			case 1:
				Screen.SetResolution(1280, 720, true);
				Debug.Log("1280");
				break;
			case 2:
				Screen.SetResolution(1920, 1080, true);
				Debug.Log("1920");
				break;
		}
		//Debug.Log("id " + id + " selected");
	}

	public void exit()
    {
		ExitPanel.SetActive(true);
    }
	public void LoadLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
        //Application.LoadLevel("SampleScene");
    }
}

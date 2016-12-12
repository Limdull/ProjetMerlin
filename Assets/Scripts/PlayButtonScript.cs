using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
    }
	public void OnClickAction()
    {
        SceneManager.LoadSceneAsync("1er mission du jeu", LoadSceneMode.Single);
    }
	// Update is called once per frame
	void Update () {
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayGame : MonoBehaviour {
    public Button playB;
    public Button ExitB;

    void Start()
    {
        ExitB.onClick.AddListener(() => { Application.Quit();});
    }
	void Update () {

	}
}

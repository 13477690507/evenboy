using UnityEngine;
using System.Collections;

public class Scenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnGUI()
    {
        //1移动方块
        if (GUI.Button(new Rect(0, Screen.height - 50, 100, 50), "1movingCube"))
        {
            Application.LoadLevel("1movingCube");
        }
        //3山体
        if (GUI.Button(new Rect(100, Screen.height - 50, 100, 50), "3Terrain"))
        {
            Application.LoadLevel("3Terrain");
        }
        //6预设
        if (GUI.Button(new Rect(200, Screen.height - 50, 100, 50), "6Prefab"))
        {
            Application.LoadLevel("6Prefab");
        }
        //7声音
        if (GUI.Button(new Rect(300, Screen.height - 50, 100, 50), "7Sound"))
        {
            Application.LoadLevel("7Sound");
        }
        //8 Helloworld
        if (GUI.Button(new Rect(400, Screen.height - 50, 100, 50), "8HelloWorld"))
        {
            Application.LoadLevel("8HelloWorld");
        }
        //8 登录框
        if (GUI.Button(new Rect(500, Screen.height - 50, 100, 50), "8LoginPanel"))
        {
            Application.LoadLevel("8LoginPanel");
        }
        //9场景
        if (GUI.Button(new Rect(600, Screen.height - 50, 100, 50), "a"))
        {
            Application.LoadLevel("a");
        }
    }
}

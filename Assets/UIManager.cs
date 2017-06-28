using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public float time = 0;
    public char direction;

    public GameObject RightOver,LeftOver;

    public static UIManager instance;



    void Awake() { instance = this; }


    public void SceneMove(string SceneName){
         SceneManager.LoadScene(SceneName);
    }
    public void CameraMove(Camera camera)
    {
            switch (direction)
            {
                case 'R': camera.transform.position = Vector3.Lerp(camera.transform.position, RightOver.transform.position, time); break;
                case 'L': camera.transform.position = Vector3.Lerp(camera.transform.position, LeftOver.transform.position, time); break;
                default: break;
            }
            time += Time.deltaTime * 0.1f;

    }
}

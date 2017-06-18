using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public int i = 0;

    public static UIManager instance;

    void Awake() { instance = this; }

    


    public void Scene_Home()
    {
        SceneManager.LoadScene("Home");
    }

    public void Scene_Shop()
    {
        SceneManager.LoadScene("Shop");
    }
}

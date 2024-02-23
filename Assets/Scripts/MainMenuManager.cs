using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject menuButton;
    // Start is called before the first frame update
    private void Start()
    {
        menuButton.SetActive(true);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void backBut(){
        menuButton.SetActive(true);
    }

    public void level1(){
        SceneLoader.Load("Battle");
        Debug.Log("Click Battle");
    }

    public void quit(){
        Application.Quit();
    }
}

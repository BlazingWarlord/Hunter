using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);   
    }
    public void QUIT()
    {
        Application.Quit();   
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(3);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}


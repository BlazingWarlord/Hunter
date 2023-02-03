using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinCheck : MonoBehaviour
{
    public int n;
    public GameObject[] AllObjs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AllObjs = GameObject.FindGameObjectsWithTag("Deer");
        if (AllObjs.Length == 0)
        {
            SceneManager.LoadScene(4);
        }

    }

}
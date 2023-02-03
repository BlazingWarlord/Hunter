using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGen : MonoBehaviour
{
    public GameObject tree;
    public GameObject grass;
    public GameObject rock;
    public GameObject branch;
    public GameObject mushroom;
    public GameObject tiger;
    int x, z;
    Vector3[] coords;
    public int n = 0;
    float countdown;
    float delay = 15f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<=900;i++)
        {
            x = Random.Range(-250, 250);
            z = Random.Range(-250, 250);
            Vector3 coord = new Vector3 (x, 0, z);
            Instantiate(tree, new Vector3(x, 0, z), transform.rotation);  
        }
        
        for (int i = 0; i <= 60; i++)
        {
            x = Random.Range(-250, 250);
            z = Random.Range(-250, 250);
            Instantiate(rock, new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i <= 50; i++)
        {
            x = Random.Range(-250, 250);
            z = Random.Range(-250, 250);
            Instantiate(branch, new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i <= 20; i++)
        {
            x = Random.Range(-250, 250);
            z = Random.Range(-250, 250);
            Instantiate(mushroom, new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i <= 29; i++)
        {
            x = Random.Range(-250, 250);
            z = Random.Range(-250, 250);
            Instantiate(tiger, new Vector3(x, 0, z), transform.rotation);
        }
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

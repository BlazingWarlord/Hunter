using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI fs;
    // Start is called before the first frame update
    void Start()
    {
        fs.text = "Final Score: " + PlayerPrefs.GetInt("Score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

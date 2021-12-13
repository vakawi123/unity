using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausescript : MonoBehaviour

    
{
    bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == false)            {
                FindObjectOfType<spawnscript>().GetComponent<spawnscript>().enabled = false;
                Time.timeScale = 0;
                isPaused = true;
            } else if(isPaused == true)
            {
                FindObjectOfType<spawnscript>().GetComponent<spawnscript>().enabled = true;
                Time.timeScale = 1;
                isPaused = false;
            }

        }
    }
}

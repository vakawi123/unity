using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{
    public GameObject ice;

    int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if(counter == 100)
        {
            Instantiate(ice, new Vector2(Random.Range(-9f,9f),5f), transform.rotation);
            counter = 0;
        }
    }
}

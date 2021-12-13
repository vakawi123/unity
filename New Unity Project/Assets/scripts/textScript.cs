using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    Text lifeText;
    public Text scoreText;

    public static int score = 0;
    public static int life = 3;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        life = 3;
        lifeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = "Health "+ life;
        scoreText.text = "score " + score;
    }
}

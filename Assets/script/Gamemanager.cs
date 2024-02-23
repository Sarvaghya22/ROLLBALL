using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public int score;
    public static Gamemanager inst;
    [SerializeField] Text scoreText;

    public void Incrementscore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }
    private void Awake()
    {
        inst = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

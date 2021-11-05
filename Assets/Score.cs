using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Rigidbody2D rb;

    public GameManager gameManager;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody.gameObject.name == "Ball")
        {
            score++;
            scoreText.text = score.ToString();

            gameManager.Restart();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rigidbody2D ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        //Time.timeScale = 0;

        ball.position = new Vector2(0, 0);
        //ball.AddForce(new Vector2(9.8f * -25f, 9.8f * 25f));
     
        //Time.timeScale = 1;
    }
}

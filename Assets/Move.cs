using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public string moveUp;
    public string moveDown;
    [SerializeField]
    private float speed = 150f;
    [SerializeField]
    private Rigidbody2D rb;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            movement.y = 1;
            Debug.Log(movement.y);
        }
        else if (Input.GetKey(moveDown))
        {
            movement.y = -1;
            Debug.Log(movement.y);
        }
        else
        {
            movement.y = 0;
        }
    }

    private void FixedUpdate()
    {
        //movement.Normalize();
        rb.velocity = new Vector2(movement.x, movement.y * speed * Time.fixedDeltaTime);
    }
}

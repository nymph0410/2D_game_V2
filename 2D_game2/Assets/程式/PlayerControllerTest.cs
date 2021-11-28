using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 rubyMove = new Vector2();
        rubyMove = transform.position;
        rubyMove.x += Input.GetAxis("Horixontal") * Time.deltaTime;
        rubyMove.y -= Input.GetAxis("Vertical") * Time.deltaTime;

        rb.MovePosition(rubyMove);
    }
}

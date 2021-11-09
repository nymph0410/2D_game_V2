using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rubyMove = transform.position;
        rubyMove.x = rubyMove.x + Input.GetAxis("Horizontal") * moveSpeed;

        transform.position = rubyMove;
    }
}

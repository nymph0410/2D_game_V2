using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyMove : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 rubyPostion = transform.position;
        rubyPostion.x = rubyPostion.x = 0.01f;
        transform.position = rubyPostion;

    }
}

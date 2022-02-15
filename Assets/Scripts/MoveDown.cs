using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveDown : MonoBehaviour
{
    Rigidbody2D rb;

    // move it via velocity
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void FixedUpdate()
	{
        rb.MovePosition(rb.position + new Vector2(0, -0.04f));
	}
    
}

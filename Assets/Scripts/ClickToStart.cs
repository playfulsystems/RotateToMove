using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToStart : MonoBehaviour
{
    void Start()
    {
        // pauses the game (physics-based)
        Time.timeScale = 0;
    }

    void Update()
    {
        // any key press starts the game
        if (Input.anyKey)
	    {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }
}

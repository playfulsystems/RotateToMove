using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToStart : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.anyKey)
	    {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }
}

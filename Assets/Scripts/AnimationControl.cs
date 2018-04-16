using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{

    // Use this for initialization
    Animator scriptToControl;

    void Start()
    {
        scriptToControl = gameObject.GetComponent<Animator>();
		scriptToControl.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            scriptToControl.enabled = !scriptToControl.enabled;
        }

    }
}

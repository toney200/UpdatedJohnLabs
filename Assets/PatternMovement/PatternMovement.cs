﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlData
{
    public float moveX;
    public float moveY;
    
}

public class PatternMovement : MonoBehaviour {

    private ControlData[] pattern;
    private int patternIndex = 0;
    public float speed = 1;

	// Use this for initialization
	void Start ()
    {
        // Create some control data
        ControlData pdr = new ControlData();
        pdr.moveX = 3.0f;
        pdr.moveY = -3.0f;

        ControlData pdl = new ControlData();
        pdl.moveX = -3.0f;
        pdl.moveY = -3.0f;

        // Create a pattern (or an instruction list) with the control data
        pattern = new ControlData[] { pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr, pdr,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdr, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdr, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdr, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl,
            pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl, pdl
        };

    }
	
	// Update is called once per frame
	void Update ()
    {
        // Process the current instruction in our control data array
        ControlData cd = pattern[patternIndex];
        float deltaX = cd.moveX * speed * Time.deltaTime;
        float deltaY = cd.moveY * speed * Time.deltaTime;
        transform.position += new Vector3(deltaX, deltaY, 0);

        // Increment the patternIndex so that we move to the next piece of pattern data
        patternIndex++;

        // Reset the patternIndex if we are at the end of the instruction array
        if (patternIndex >= pattern.Length)
        {
            patternIndex = 0;
        }

    }
}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointControl : MonoBehaviour
{
    public Vector3[] pos = { new Vector3(50,0,50), new Vector3(850,0,850)};
    int checkedTimes = 0;
    private void OnTriggerEnter(Collider cl)
    {
        if(cl.gameObject.tag == "car")
        {
            checkedTimes++;
            transform.position = pos[checkedTimes % pos.Length];
        }
    }
}

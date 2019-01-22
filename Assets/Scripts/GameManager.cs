﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    void Awake()
    {
        if (_instance == null) _instance = this;
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }
}


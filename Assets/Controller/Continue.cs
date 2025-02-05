﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;

    public Color origin;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(ContinueGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContinueGame()
    {
        player.GetComponent<FPMovement>().isPaused = false;
        player.GetComponent<Animator>().speed = 1;

        light.GetComponent<Light>().color = origin;
        if (menu)
        {
            menu.GetComponent<visibility>().disappear();
        }
    }
}

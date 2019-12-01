﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaraEncounter : MonoBehaviour
{
    [SerializeField]
    GameObject player, bush, lara;

    public AudioSource audioSource;
    private int counter = 0;

    private bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        lara.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x <= 6 && counter == 0)
        {
            Fungus.Flowchart.BroadcastFungusMessage("surprised");
            counter++;
        }
        if (player.transform.position.x <= 0.3 && counter == 1)
        {
            lara.SetActive(true);
            counter++;
        }
        if(counter == 2)
        {
            Fungus.Flowchart.BroadcastFungusMessage("start");
            counter++;
        }


    }

    //void StartCutscene()
    //{
    //    audioSource.Play();

    //    StartCoroutine(delay(3));
    //    if(player.transform.position.x <= 0.2)
    //    {
    //        Debug.Log("AAAAAAAAAAA");
    //        lara.SetActive(true);
    //    }
    //}

    private void configureAnim()
    {
        if(player.GetComponent<Movement>().enabled) player.GetComponent<Movement>().enabled = false;
        else player.GetComponent<Movement>().enabled = true;
    }

    private void hideLara()
    {
        lara.SetActive(false);
    }
}

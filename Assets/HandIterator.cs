using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandIterator : MonoBehaviour
{

    public List<GameObject> handList = new List<GameObject>();
    public int currentHandindex = 0;

    // Use this for initialization
    void Start()
    {
        showHands();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            nextHand();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            previousHand();
        }
    }

    private void previousHand()
    {
        Debug.Log("Previous Hand");
        currentHandindex--;
        if (currentHandindex < 0)
            currentHandindex = handList.Count - 1;
        showHands();
    }

    private void showHands()
    {
        Debug.Log("Show Hand");
        int i = 0;
        foreach (GameObject child in handList)
        {
            child.SetActive(true);
            if (i != currentHandindex) child.SetActive(false);
            i++;
        }
    }
   
    private void nextHand()
    {
        Debug.Log("Previous Hand");
        currentHandindex++;
        if (currentHandindex > handList.Count - 1)
            currentHandindex = 0;
        showHands();
    }
}
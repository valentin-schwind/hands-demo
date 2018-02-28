using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardShit : MonoBehaviour {

    public TextMesh textMesh;
    public GameObject scene;
    public Camera cameraRig;

    private float sceneHeight = 0;
	// Use this for initialization
	void Start () {
        textMesh.text = "";

    }
	
	// Update is called once per frame
	void Update () {
        foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(key))
            {
                switch (key.ToString().ToLower())
                {
                    case "r":
                        scene.transform.position.Set(cameraRig.transform.position.x, sceneHeight, cameraRig.transform.position.z) ;
                        break;
                    case "space":
                        textMesh.text += " ";
                        break;
                    case "return":
                        textMesh.text += "\n";
                        break;
                    case "mouse0": break;
                    case "mouse1": break;
                    case "mouse2": break;
                    case "leftalt": break;
                    case "rightalt": break;
                    case "leftarrow": break;
                    case "rightarrow": break;
                    case "uparrow":
                        
                        break;
                    case "downarrow":
                        
                        break;
                    case "left": break;
                    case "right": break;
                    case "alt": break;
                    case "leftshift": break;
                    case "rightshift": break;
                    case "leftcontro": break;
                    case "rightcontrol": break;
                    case "leftcommand": break;
                    case "rightcommand": break;
                    default:
                        textMesh.text += key.ToString().ToLower();
                        break;
                }
                
            }
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            textMesh.text = "";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    public string[] text = {
        "Welcome to the lab \n(Press Space to advance text)",
        "You are trapped \nin a secret underground lab",
        "You were running \nan experiment...",
        "...To find a cure for \nmale pattern baldness",
        "You accidentally pressed the \nlab self destruct button",
        "D: OH NOOOOOOO",
        "You need to find the \nONE BUTTON",
        "That will keep\nthe lab from exploding",
        "GOOD LUCK",
        "...",
        "...",
        "What are you \nwaiting for?",
        ""
    };

    private int i;

    public GameObject UIText;
    private Text t;


	// Use this for initialization
	void Start () {
        t = UIText.GetComponent<Text>();
        t.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            i += 1;
            if (i >= text.Length) { i = 0; }
            t.text = text[i];
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        t.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        t.enabled = false;
    }
}

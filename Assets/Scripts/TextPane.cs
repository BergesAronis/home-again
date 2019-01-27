using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPane : MonoBehaviour
{
    private float startTime;
    private bool canContinue;
    public Text textBox;
    public bool open = false;


    private float continueDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        this.ClosePane();
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.canContinue && Time.time > this.startTime + this.continueDelay)
        {
            this.canContinue = true;
        }
    }

    void OnMouseDown()
    {
        this.ClosePane();
    }

    public void OpenPane(string text)
    {
        // TODO: add ability to pass text through for display
        this.startTime = Time.time;
        this.canContinue = false;
        this.gameObject.SetActive(true);
        textBox.text = text;
        this.open = true;
    }

    public void ClosePane()
    {
        this.gameObject.SetActive(false);
        this.open = false;
        Debug.Log("closed");
    }
}

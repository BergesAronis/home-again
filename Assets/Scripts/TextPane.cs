using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPane : MonoBehaviour
{
    private float startTime;
    private bool canContinue;

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
        // TODO: add ability to cycle through multiple dialogue panes (instead of just 1) before closing
        if (this.canContinue)
        {
            this.ClosePane();
        }
    }

    public void OpenPane()
    {
        // TODO: add ability to pass text through for display
        this.startTime = Time.time;
        this.canContinue = false;
        this.gameObject.SetActive(true);
    }

    public void ClosePane()
    {
        this.gameObject.SetActive(false);
    }
}

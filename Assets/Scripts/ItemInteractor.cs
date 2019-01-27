using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractor : MonoBehaviour
{
    public TextPane textPane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // TODO: add support for passing text through
        // TODO: add support for passing different text based on progress flags (maybe a struct? have flag options and text array to go with)
        this.textPane.OpenPane();
    }

    void OnMouseOver()
    {
        // TODO: highlight item on mouseover -- may want to change this to some sort OnEnter()/OnLeave() pair to simplify computation
    }
}

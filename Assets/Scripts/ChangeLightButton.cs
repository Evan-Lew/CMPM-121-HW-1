using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeLightButton : MonoBehaviour
{
    // create frame and button variables 
    private VisualElement frame;
    private Button button;
    
    // This function is called when the object becomes enabled and active.
    void OnEnable()
    {
        // get the UIDocument component (make sure this name matches!)
        var uiDocument = GetComponent<UIDocument>();
        // get the rootVisualElement (the frame component)
        var rootVisualElement = uiDocument.rootVisualElement;
        frame = rootVisualElement.Q<VisualElement>("Frame");
        // get the button, which is nested in the frame
        button = frame.Q<Button>("Button");
        // create event listener that calls ChangeCycle() when pressed
        button.RegisterCallback<ClickEvent>(ev => ChangeCycle());
    }

    // initialize click count
    public int click = 0;
    private void ChangeCycle()
    {
        click++;
        if (click > 2)
        {
            click = 0;
        }
    }
}
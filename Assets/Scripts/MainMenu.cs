using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    private VisualElement ui;
    
    private void Start()
    {
        ui = GetComponent<UIDocument>().rootVisualElement;
        
        ui.Q<Button>("button_start").RegisterCallback<ClickEvent>(e =>
        {
            Debug.Log("clicked button_start");
            SceneManager.LoadScene("Scenes/Playground");
        });
        
        ui.Q<Button>("button_options").RegisterCallback<ClickEvent>(e =>
        {
            Debug.Log("options");
        });
        
        ui.Q<Button>("button_quit").RegisterCallback<ClickEvent>(e =>
        {
            Application.Quit();
            Debug.Log("Quit");
        });
    }
}

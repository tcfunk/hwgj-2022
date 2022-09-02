using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class InGameMenu : MonoBehaviour
{
    private VisualElement ui;
    private VisualElement menu;
    private VisualElement optionsMenu;

    void Start()
    {
        ui = GetComponent<UIDocument>().rootVisualElement;
        menu = ui.Q<VisualElement>("menu_ingame");
        optionsMenu = ui.Q<VisualElement>("menu_options");
        
        // Set default state
        // menu.style.display = DisplayStyle.None;
        Open();

        ui.Q<Button>("button_options").RegisterCallback<ClickEvent>(e =>
        {
            menu.style.display = DisplayStyle.None;
            optionsMenu.style.display = DisplayStyle.Flex;
        });
        
        ui.Q<Button>("button_close").RegisterCallback<ClickEvent>(e =>
        {
            menu.style.display = DisplayStyle.None;
        });
        
        ui.Q<Button>("button_quit").RegisterCallback<ClickEvent>(e =>
        {
            SceneManager.LoadScene("MainMenu");
        });
        
        ui.Q<Button>("button_close_options").RegisterCallback<ClickEvent>(e =>
        {
            optionsMenu.style.display = DisplayStyle.None;
            menu.style.display = DisplayStyle.Flex;
        });
    }

    private void Open()
    {
        menu.style.display = DisplayStyle.Flex;
        optionsMenu.style.display = DisplayStyle.None;
    }
    
}

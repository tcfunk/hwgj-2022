using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    private VisualElement ui;

    private VisualElement mainMenu;
    private VisualElement optionsMenu;

    private void Start()
    {
        ui = GetComponent<UIDocument>().rootVisualElement;
        mainMenu = ui.Q<VisualElement>("menu_main");
        optionsMenu = ui.Q<VisualElement>("menu_options");
        
        // Set default state.
        optionsMenu.style.display = DisplayStyle.None;

        ui.Q<Button>("button_start").RegisterCallback<ClickEvent>(e =>
        {
            SceneManager.LoadScene("Scenes/Playground");
        });

        ui.Q<Button>("button_options").RegisterCallback<ClickEvent>(e =>
        {
            mainMenu.style.display = DisplayStyle.None;
            optionsMenu.style.display = DisplayStyle.Flex;
        });
        
        ui.Q<Button>("button_close_options").RegisterCallback<ClickEvent>(e =>  {
            optionsMenu.style.display = DisplayStyle.None;
            mainMenu.style.display = DisplayStyle.Flex;
        });

        ui.Q<Button>("button_quit").RegisterCallback<ClickEvent>(e => {
            Application.Quit();
            Debug.Log("Quit");
        });
    }
}

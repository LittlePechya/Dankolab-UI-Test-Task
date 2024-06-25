using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject _playMenu;
    [SerializeField] private GameObject _settingsMenu;

    [Header("Buttons")]
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _closePlayMenuButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _closeSettingsMenuButton;

    private void Start() 
    {
        InitializeButtons();
    }

    private void InitializeButtons()
    {
        _playButton.onClick.AddListener(() => ToggleMenu(_playMenu, true));
        _settingsButton.onClick.AddListener(() => ToggleMenu(_settingsMenu, true));

        _closePlayMenuButton.onClick.AddListener(() => ToggleMenu(_playMenu, false));
        _closeSettingsMenuButton.onClick.AddListener(() => ToggleMenu(_settingsMenu, false));
    }

    private void ToggleMenu(GameObject menu, bool isOpen)
    {
        menu.SetActive(isOpen);
        Debug.Log((isOpen ? "Открыто" : "Закрыто") + " меню: " + menu.name);
    }
}

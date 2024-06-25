using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    private GameObject _panel; // This panel is the parent for the buttons
    private Button[] _buttons;

    private void Start() 
    {
        _panel = gameObject;
        _buttons = _panel.GetComponentsInChildren<Button>();
        InitializeButtons(_buttons);
    }

    private void InitializeButtons(Button[] buttons)
    {
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => DeleteButton(button));
        }
    }

    private void DeleteButton(Button button)
    {
        Destroy(button.gameObject);
        Debug.Log("Элемент удален");
    }
}

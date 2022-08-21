using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScreen : Screen
{
    [SerializeField] private MenuScreen _menuScreen;
    public override void SetActionToCancelButton()
    {
        CancelButton.AddListener(() => _menuScreen.TurnOn());
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScreen : Screen
{
    [SerializeField] private MenuScreen _menuScreen;
    [SerializeField] private  List<ToggleOfSettings> _togglesOfSettings;
    private void Awake() 
    {
        _togglesOfSettings.ForEach(e=>e.TryLoad());
    } 
    public override void SetActionToCancelButton()
    {
        _togglesOfSettings.ForEach(e=>e.Save());
        CancelButton.ChangeEvent(() => _menuScreen.TurnOn());
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelecterScreen : Screen
{
    [SerializeField] private MenuScreen _menuScreen;
    [SerializeField] private ContinieGameButton _continieGameButton;
    public override void SetActionToCancelButton()
    {
        CancelButton.ChangeEvent(() => _menuScreen.TurnOn());
        Saver<SavableSelectedCharacter>.Save(new SavableSelectedCharacter(""));
        _continieGameButton.gameObject.SetActive(false);
    }
}

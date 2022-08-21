using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickableChracter : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Player _player;
    private LoaderScene _loaderScene;
    private void Start() 
    {
        _loaderScene = FindObjectOfType<LoaderScene>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick();
    }
    private void OnClick()
    {
        Saver<SavableSelectedCharacter> saver = new Saver<SavableSelectedCharacter>();
        saver.Save(new SavableSelectedCharacter(_player.PlayerInformation.Name));
        _loaderScene.OpenGame();
    }
}

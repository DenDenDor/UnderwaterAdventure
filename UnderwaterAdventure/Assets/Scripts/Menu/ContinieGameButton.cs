using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinieGameButton : MonoBehaviour
{
   [SerializeField] private LoaderScene _loaderScene;
   private void Start() 
   {
    Loader<SavableSelectedCharacter> loader = new Loader<SavableSelectedCharacter>();
    string nameOfPlayer = loader.Load(new SavableSelectedCharacter()).NameOfSelectedCharacter;
    if (nameOfPlayer == "")
    {
        gameObject.SetActive(false);
    }
   }
   public void OnClick()
   {
         _loaderScene.OpenGame();
   }
}

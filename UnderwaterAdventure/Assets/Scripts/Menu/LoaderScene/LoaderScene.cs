using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoaderScene : MonoBehaviour
{
   public void OpenGame() => StartCoroutine(LoadScene("Game"));
   public void OpenMenu() => StartCoroutine(LoadScene("Menu"));
   private IEnumerator LoadScene(string nameOfScene)
   {
    AsyncOperation asyncOperation =UnityEngine.SceneManagement. SceneManager.LoadSceneAsync(nameOfScene);
    while (!asyncOperation.isDone)
    {
          yield return null;
    }
    SceneManager.LoadScene(nameOfScene);
   }
}

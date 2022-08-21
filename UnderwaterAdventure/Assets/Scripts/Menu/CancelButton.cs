using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class CancelButton : MonoBehaviour
{
    
    [SerializeField] private Button _button;
    public void AddListener(UnityAction action)
    {
        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(action);
    }
}

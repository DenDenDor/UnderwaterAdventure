using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class ToggleOfSettings : MonoBehaviour
{
   [SerializeField] private Toggle _toggle;

    public Toggle Toggle { get => _toggle; private set => _toggle = value; }
    public abstract void TryLoad();
    public abstract void Save();
    public void ChangeStateOfToggle(ISavable iSavable,bool isOn)
    {
        if (iSavable != null)
        {
            Toggle.isOn = isOn;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMouseButtonHandler : MonoBehaviour
{
    public event Action OnGetLeftMouseButtonUp;
    public event Action OnGetLeftMouseButtonDown;
    public event Action OnGetRightMouseButtonDown;
    private void Update() 
    {
         if (Input.GetMouseButtonDown(1))
      {
          //OnGetRightMouseButtonDown?.Invoke();
      }  
      if (Input.GetMouseButtonUp(0))
      {
        Debug.Log("COOl =");
        OnGetLeftMouseButtonUp?.Invoke();
      }
    }
}

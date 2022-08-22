using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefresherSlot : MonoBehaviour
{
    [SerializeField] private SlotCollector _slotCollector;
    private void Start() 
    {
      _slotCollector.OnRefresh +=  Refresh;
    }
    private void Refresh((Slot firstSlot, Slot secondSlot) coupleOfSlots)
    {
       Slot additionalSlot = coupleOfSlots.firstSlot;
       Vector2 position = additionalSlot.transform.position;
       coupleOfSlots.firstSlot.Replace(coupleOfSlots.secondSlot.transform.position);
       coupleOfSlots.secondSlot.Replace(position);
    }
    private void OnDisable() 
    {
       _slotCollector.OnRefresh -=  Refresh;
    }
}

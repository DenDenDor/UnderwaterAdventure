using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SlotCreator : Creator<Slot> 
{
   [SerializeField] private int _countOfSlots = 8;
   [SerializeField] private List<Item> _items;
   [SerializeField] private Transform _slotPosition;
   public event Action<List<Slot>> OnCreate;
   private void Start() 
   {
        List<Slot> slots = new List<Slot>();
        for (int i = 0; i < _countOfSlots; i++)
        {
           Slot slot = Create(Vector2.zero);
           slot.AddItem(_items[UnityEngine.Random.Range(0,_items.Count)]);
           slot.transform.SetParent(_slotPosition);
           slots.Add(slot);
        }
        OnCreate?.Invoke(slots);
    }
}

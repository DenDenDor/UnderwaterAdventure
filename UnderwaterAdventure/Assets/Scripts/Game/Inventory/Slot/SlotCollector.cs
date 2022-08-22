using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SlotCollector : MonoBehaviour
{
    [SerializeField] private SlotCreator _slotCreator;
    private List<Slot> _slots = new List<Slot>();
    private Slot _currentSlot;
    public Slot CurrentSlot { get => _currentSlot; private set => _currentSlot = value; }
    public event Action<(Slot firstSlot, Slot secondSlot)> OnRefresh;
    public event Action OnChoose;
    public event Action OnCancelSlot;
    private void Awake()
    {
        _slotCreator.OnCreate+=GetAllSlots; 
        OnCancelSlot += RemoveItem;
    }
    private void RemoveItem() => CurrentSlot = null;
    private void Update() 
    {
      if (Input.GetMouseButtonDown(1))
      {
          OnCancelSlot?.Invoke();
      }  
    }
    private void GetAllSlots(List<Slot> slots)
    {
         _slots = slots;
         _slots.ForEach(e=>e.OnClick += ChooseSlot);
    }
    private void ChooseSlot(Slot slot)
    {
        if (_currentSlot != null && slot.Item.Name != _currentSlot.Item.Name)
        {
            OnRefresh?.Invoke((_currentSlot,slot));
            OnCancelSlot?.Invoke();
            return;
        }
        _currentSlot = slot;
        OnChoose?.Invoke();
    }
    private void OnDisable() 
    {
        _slots.ForEach(e=>e.OnClick -= ChooseSlot);
        _slotCreator.OnCreate-= GetAllSlots; 
        OnCancelSlot -= RemoveItem;
    }
}

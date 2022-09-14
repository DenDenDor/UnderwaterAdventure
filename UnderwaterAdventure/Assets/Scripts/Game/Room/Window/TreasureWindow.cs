using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureWindow : GameWindow
{
    [SerializeField] private List<Item> _items = new List<Item>();
    private SlotCollector _slotCollector;
    private void Awake() 
    {
      _slotCollector = FindObjectOfType<SlotCollector>();
      _slotCollector.OnRefresh += CheckTreasureSlot;
      _slotCollector.SlotCreator.CreateTreasureSlot(_items[Random.Range(0,_items.Count)]);   
    }
    private void CheckTreasureSlot((Slot,Slot) tuple)
    {
        
    }
    public void Close()
    {
        DoorCreator doorCreator = FindObjectOfType<DoorCreator>();
        doorCreator.OpenAllDoors();
        Destroy(gameObject);
    }
    private void OnDisable() 
    {
        _slotCollector.SlotCreator.DestroyTreasureSlot();
        _slotCollector.OnRefresh -= CheckTreasureSlot;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
  [SerializeField] private Sprite _sprite;
  [SerializeField] private string _name;
   public Sprite Sprite { get => _sprite; private set => _sprite = value; }
   public string Name { get => _name; private set => _name = value; }
}

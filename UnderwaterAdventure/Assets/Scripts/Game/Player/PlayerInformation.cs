using System.Net.NetworkInformation;
using System;
using UnityEngine;
[Serializable]
public class PlayerInformation 
{
    [SerializeField] private string _name;
    public string Name { get => _name; set => _name = value; }
}

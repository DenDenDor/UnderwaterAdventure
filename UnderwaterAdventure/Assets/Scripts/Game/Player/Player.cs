using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private PlayerInformation _playerInformation;
    public PlayerInformation PlayerInformation { get => _playerInformation; set => _playerInformation = value; }
}

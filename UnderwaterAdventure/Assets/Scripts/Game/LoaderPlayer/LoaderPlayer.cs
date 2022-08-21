using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderPlayer : MonoBehaviour
{
   [SerializeField] private List<Player> _players;
   private Player _currentPlayer;
   private void Start() 
   {
    Loader<SavableSelectedCharacter> loader = new Loader<SavableSelectedCharacter>();
     string nameOfPlayer = loader.Load(new SavableSelectedCharacter()).NameOfSelectedCharacter;
     _currentPlayer =CreatePlayer(_players.Find(e=> e.PlayerInformation.Name == nameOfPlayer));
   }
   private Player CreatePlayer(Player player)
   {
    return Instantiate(player,Vector3.zero,Quaternion.identity);
   }
}

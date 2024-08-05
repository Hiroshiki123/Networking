using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Unity.VisualScripting;

public class MultplayerManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        //cria a conexão 
        PhotonNetwork.ConnectUsingSettings();
            
    }

    
    private void OnFailedToConnectToMasterServer()
    {
        //Quando houver conexão recebe os jogadores
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        // quando houver conexão criar um lobby e define as propriedades da sala
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions{MaxPlayers = 4}, TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        //instancia o jogador
        PhotonNetwork.Instantiate("Player", Vector2.zero,Quaternion.identity);
    }
    
}

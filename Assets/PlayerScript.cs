using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerScript : MonoBehaviourPunCallbacks
{
    
    void Update()
    {

        if (photonView.IsMine == false)
            return;
        
            float move = Input.GetAxis("Horizontal") * 10.0f * Time.deltaTime;
            transform.Translate(move, 0, 0);
        
    }
}

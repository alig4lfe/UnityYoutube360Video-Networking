using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class VideoSpawner : NetworkBehaviour {
    // Is Live Stream A special Type of object 
    public override void OnStartServer()
    {
        NetworkServer.SpawnObjects();
    }
}
   


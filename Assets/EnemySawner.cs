using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnemySawner : NetworkBehaviour {

    public GameObject LiveStream;
    public override void OnStartServer()
    {
        NetworkServer.SpawnObjects();
    }
}

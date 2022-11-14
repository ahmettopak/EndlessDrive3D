using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public RoadSpawnController roadSpawnController;

    private void Start() {
        roadSpawnController = GetComponent<RoadSpawnController>();
    }
    public void RoadSpawnEntered() {
        roadSpawnController.MoveRoad();
    }
}

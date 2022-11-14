using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
     RoadSpawnController roadSpawnController;
     BarrierSpawnController barrierSpawnController;
     CoinsSpawnController coinSpawnController;
  
  
    private void Start() {
        roadSpawnController = GetComponent<RoadSpawnController>();  
        barrierSpawnController = GetComponent<BarrierSpawnController>();   
        coinSpawnController = GetComponent<CoinsSpawnController>(); 
    }

    public void RoadSpawnEntered() {
        roadSpawnController.MoveRoad();
    } 
    public void BarrierSpawnEntered() {
        barrierSpawnController.SpawnBarrier();
    }
    public void CoinSpawnEntered() {
        coinSpawnController.SpawnCoin();
    }
}

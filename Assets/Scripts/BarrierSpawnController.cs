using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawnController : MonoBehaviour {
    float lastSpawnX;
    public float lastSpawnY;
    public float lastSpawnZ;
    public float destroyLenght;


    public float spawnInterval;
    public List<GameObject> obstacles;


    private void Start() {

    }


    public void SpawnBarrier() {
        if (Random.Range(0, 1) == 0) {
            lastSpawnX = -1;

        }
        else {
            lastSpawnX = 1;
        }
        lastSpawnZ += spawnInterval;
        GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];
        var clone = Instantiate(obstacle, new Vector3(lastSpawnX, lastSpawnY, lastSpawnZ), obstacle.transform.rotation);
        Destroy(clone, destroyLenght);



    }



}

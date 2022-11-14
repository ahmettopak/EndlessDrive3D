using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject car;
    public float speed;
    public float turnSpeed;
    public Vector3 velocity;
    public SpawnManager spawnManager;

    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        car.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z+speed/8);
        car.transform.position += velocity*turnSpeed*Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {
        spawnManager.RoadSpawnEntered();      
    }


}

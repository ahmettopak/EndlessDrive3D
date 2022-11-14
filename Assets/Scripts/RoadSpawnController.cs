using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawnController : MonoBehaviour
{
   
    public List<GameObject> RoadList = new List<GameObject>();
    public float offset;

    void Start()
    {
        if (RoadList != null& RoadList.Count>0) {
            RoadList = RoadList.OrderBy(r => r.transform.position.z).ToList(); 
        }
    }
    public void MoveRoad() {
        GameObject moveRoad = RoadList[0];
        RoadList.Remove(moveRoad);
        float newZ = RoadList[RoadList.Count-1].transform.position.z+offset;
        moveRoad.transform.position= new Vector3 (0, 0, newZ);
        RoadList.Add(moveRoad);
        
    }
}

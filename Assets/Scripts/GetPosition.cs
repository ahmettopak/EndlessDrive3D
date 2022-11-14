using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPosition : MonoBehaviour
{
    public float zLocation=0;
    void Update()
    {
        zLocation = transform.position.z;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarkManager : MonoBehaviour
{
    public int speed = 35;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}

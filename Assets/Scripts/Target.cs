using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    Transform radius;
    Vector3 velocity = Vector3.zero;
    Vector3 desired = Vector3.zero;
    Vector3 steer = Vector3.zero;

    float maxSpeed = 10;
    float maxSteer = 1;

    Transform target;


    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Target").transform;
        radius = GameObject.Find("Area").transform;

        float R = (radius.transform.position - transform.position).magnitude;


        desired = (target.position - transform.position).normalized * maxSpeed;// desired -= para que huya del target
        steer = Vector3.ClampMagnitude(desired - velocity, maxSteer);

        velocity +=steer * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }
}

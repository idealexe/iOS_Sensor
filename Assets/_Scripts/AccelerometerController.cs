using UnityEngine;
using System.Collections;

public class AccelerometerController : MonoBehaviour
{
    private Vector3 acceleration;

    void Start()
    {
        acceleration = Vector3.zero;
    }

    void FixedUpdate()
    {
        acceleration = Input.acceleration;
    }

    public Vector3 getAcceleraion()
    {
        return (acceleration);
    }
}

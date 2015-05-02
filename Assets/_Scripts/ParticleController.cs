using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem particleSystem;
    public AccelerometerController accelerationControler;
    private Vector3 acceleration;

    void Start()
    {
        particleSystem = gameObject.GetComponent<ParticleSystem>();
    }

    void Update()
    {
        acceleration = accelerationControler.getAcceleraion();
        acceleration.x = -3;
        gameObject.transform.position = acceleration;
    }
}

using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem particleSystem;
    private GameObject acceleraion;

    // Use this for initialization
    void Start()
    {
        particleSystem = gameObject.GetComponent<ParticleSystem>();
    }

    void FixedUpdate()
    {
    }
}

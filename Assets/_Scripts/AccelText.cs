using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.iOS;

public class AccelText : MonoBehaviour
{
    private Text accelText;
    public Vector3 acceleration;
    public GameObject particleSystem;

    void Start()
    {
        accelText = gameObject.GetComponent<Text>();
        acceleration = Vector3.zero;
        particleSystem = GameObject.Find("Particle System");
    }

    void FixedUpdate()
    {
        updateAcceleration();
    }

    private void updateAcceleration()
    {
        acceleration = Input.acceleration;
        accelText.text = "Accel X: " + acceleration.x.ToString("F4")
            + "\nAccel Y: " + acceleration.y.ToString("F4")
            + "\nAccel Z: " + acceleration.z.ToString("F4");

        particleSystem.transform.position.y = acceleration.y;
    }

    public Vector3 getAcceleration()
    {
        return (acceleration);
    }
}
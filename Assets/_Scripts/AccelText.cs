using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.iOS;

public class AccelText : MonoBehaviour
{
    private Text accelText;
    private Vector3 acceleration;

    void Start()
    {
        accelText = gameObject.GetComponent<Text>();
        acceleration = Vector3.zero;
    }

    void FixedUpdate()
    {
        updateAcceleration();
    }

    private void updateAcceleration()
    {
        acceleration = Input.acceleration;
        accelText.text = "Accel X: " + acceleration.x
            + "\nAccel Y: " + acceleration.y
            + "\nAccel Z: " + acceleration.z;
    }
}
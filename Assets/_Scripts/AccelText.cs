using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AccelText : MonoBehaviour
{
    private Text accelText;
    private Vector3 acceleration;

    public AccelerometerController accelerometerController;

    void Start()
    {
        accelText = gameObject.GetComponent<Text>();
        acceleration = Vector3.zero;
    }

    void FixedUpdate()
    {
        updateAccelText();
    }

    private void updateAccelText()
    {
        acceleration = accelerometerController.getAcceleraion();
        accelText.text = "Accel X: " + acceleration.x.ToString("F4")
            + "\nAccel Y: " + acceleration.y.ToString("F4")
            + "\nAccel Z: " + acceleration.z.ToString("F4");
    }
}
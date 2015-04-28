using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.iOS;

public class AccelText : MonoBehaviour{
    private Text accelText;
    private Vector3 acceleration;

	// Use this for initialization
	void Start () {
        accelText = gameObject.GetComponent<Text>();
        acceleration = Vector3.zero;

        drawAcceleration();
	
	}
	
	// Update is called once per frame
	void Update () {
        acceleration = Input.acceleration;
        drawAcceleration();

	
	}

    private void drawAcceleration()
    {
        accelText.text = "Accel X: " + acceleration.x
            + "\nAccel Y: " + acceleration.y
            + "\nAccel Z: " + acceleration.z;
    }
}
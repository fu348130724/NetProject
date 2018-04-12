using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCarController : MonoBehaviour {

    public List<AxleInfo> axleInfos;
    public float maxMotorTorque;
    public float maxSteeringAngle;


    public void FixedUpdate() {

        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        foreach (AxleInfo ax in axleInfos)
        {
            if (ax.steering) {

                ax.leftWheel.steerAngle = steering;
                ax.rightwheel.steerAngle = steering;
                //
            }

            if (ax.motor) {

                ax.leftWheel.motorTorque = motor;
                ax.rightwheel.motorTorque = motor;
            }
        }
    }

}

[System.Serializable]
public class AxleInfo {

    public WheelCollider leftWheel;
    public WheelCollider rightwheel;
    public bool motor;
    public bool steering;

}

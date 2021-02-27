using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giroscopio : MonoBehaviour
{
    public GameObject vrCameras;
    private float initialPosY = 0f, roundY = 0f, calibrateY = 0f;

    public bool gameInitialized;

    void Start()
    {
        Input.gyro.enabled = true;
        initialPosY = vrCameras.transform.eulerAngles.y;
    }

    void Update()
    {
        ApplyRotationGyroscope();
        ApplyCalibration();

        if (gameInitialized)
        {
            Invoke("CalibratePositionY",3f);
            gameInitialized = false;
        }
    }

    void ApplyRotationGyroscope()
    {
        vrCameras.transform.rotation = Input.gyro.attitude;
        vrCameras.transform.Rotate(0f, 0f, 180f, Space.Self);
        vrCameras.transform.Rotate(90f, 180f, 0f, Space.World);
        roundY = vrCameras.transform.eulerAngles.y;
    }

    void CalibratePositionY()
    {
        calibrateY = roundY - initialPosY;
    }

    void ApplyCalibration()
    {
        vrCameras.transform.Rotate(0f, -calibrateY, 0f, Space.World);
    }
}

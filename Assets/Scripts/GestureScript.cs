using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;


public class GestureScript : MonoBehaviour
{
    private bool OKHandPose = false;
    private float speed = 30.0f;  // Speed of our cube
    private float distance = 2.0f; // Distance between Main Camera and the cube
    private GameObject cube; // Reference to our Cube
    private MLHandTracking.HandKeyPose[] gestures; // Holds the different hand poses we will look for

    // Start is called before the first frame update
    void Start()
    {
        MLHandTracking.Start(); // Start the hand tracking.

        gestures = new MLHandTracking.HandKeyPose[4]; //Assign the gestures we will look for.
        gestures[0] = MLHandTracking.HandKeyPose.Ok;
        gestures[1] = MLHandTracking.HandKeyPose.Fist;
        gestures[2] = MLHandTracking.HandKeyPose.OpenHand;
        gestures[3] = MLHandTracking.HandKeyPose.Finger;
        // Enable the hand poses.
        MLHandTracking.KeyPoseManager.EnableKeyPoses(gestures, true, false);

        cube = GameObject.Find("Cube"); // Find our Cube in the scene.
        cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OKHandPose)
        {
            if (GetGesture(MLHandTracking.Left, MLHandTracking.HandKeyPose.OpenHand)
            || GetGesture(MLHandTracking.Right, MLHandTracking.HandKeyPose.OpenHand))
                cube.transform.Rotate(Vector3.up, +speed * Time.deltaTime);

            if (GetGesture(MLHandTracking.Left, MLHandTracking.HandKeyPose.Fist)
            || GetGesture(MLHandTracking.Right, MLHandTracking.HandKeyPose.Fist))
                cube.transform.Rotate(Vector3.up, -speed * Time.deltaTime);

            if (GetGesture(MLHandTracking.Left, MLHandTracking.HandKeyPose.Finger))
                cube.transform.Rotate(Vector3.right, +speed * Time.deltaTime);

            if (GetGesture(MLHandTracking.Right, MLHandTracking.HandKeyPose.Finger))
                cube.transform.Rotate(Vector3.right, -speed * Time.deltaTime);
        }
        else
        {
            if (GetGesture(MLHandTracking.Left, MLHandTracking.HandKeyPose.Ok)
            || GetGesture(MLHandTracking.Right, MLHandTracking.HandKeyPose.Ok))
            {
                OKHandPose = true;
                cube.SetActive(true);
                cube.transform.position = transform.position
                  + transform.forward * distance;
                cube.transform.rotation = transform.rotation;
            }
        }
    }

    private void OnDestroy()
    {
        MLHandTracking.Stop();
    }

    bool GetGesture(MLHandTracking.Hand hand, MLHandTracking.HandKeyPose type)
    {
        if (hand != null)
        {
            if (hand.KeyPose == type)
            {
                if (hand.HandKeyPoseConfidence > 0.9f)
                {
                    return true;
                }
            }
        }
        return false;
    }


}

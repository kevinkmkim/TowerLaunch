using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{

    private void Start() {
        GyroManager.Instance.EnableGyro();
    }

    private void Update() {
        transform.localRotation = Quaternion.Euler(0, 0, GyroManager.Instance.GetGyroRotation().eulerAngles.z * -1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject cameraReference;
    Vector3 vector3 = new Vector3(0, 0, -10);

    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// It is called after all Update functions have been called.
    /// </summary>
    void LateUpdate()
    {
        transform.position = cameraReference.transform.position + (vector3);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

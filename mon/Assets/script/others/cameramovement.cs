using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    public Transform Target;
    public float Smoothing;
    public Vector2 MinPosition;
    public Vector2 MaxPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 TargetPosition = new Vector3(Target.position.x, Target.position.y, transform.position.z);
        if (transform.position != Target.position) {
            TargetPosition.x = Mathf.Clamp(TargetPosition.x, MinPosition.x, MaxPosition.x);
            TargetPosition.y = Mathf.Clamp(TargetPosition.y, MinPosition.y, MaxPosition.y);
            transform.position = Vector3.Lerp(transform.position, TargetPosition, Smoothing);
        }
    }
}

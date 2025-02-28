using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roommove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 CameraChange;
    public Vector3 PlayerMove;
    private cameramovement Cam;
    void Start()
    {
        Cam = Camera.main.GetComponent<cameramovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            Cam.MinPosition += CameraChange;
            Cam.MaxPosition += CameraChange;
            other.transform.position += PlayerMove;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float Speed = 10f;
    public Vector3 Change;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Change = Vector3.zero;
        Change.x = Input.GetAxisRaw("Horizontal");
        Change.y = Input.GetAxisRaw("Vertical");
        if (Change != Vector3.zero) {
            playerMoveMent();
        }
    }
    void playerMoveMent() {
        Change.Normalize();
        Rb.MovePosition(
            transform.position + Change * Speed * Time.deltaTime
        );
    }
}

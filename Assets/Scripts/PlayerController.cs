using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float m_Speed;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis ("Horizontal");
        float verticalInput = Input.GetAxis ("Vertical");
        Vector3 inputMovement = new Vector3(horizontalInput, 0, verticalInput);
        _rigidbody.MovePosition(transform.position + inputMovement * Time.deltaTime * m_Speed);
    }
}

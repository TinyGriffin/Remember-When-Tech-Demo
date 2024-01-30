using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [Header("Ground Check")]

    public float playerHeight;
    public LayerMask whatIsGround;
    bool onGround;
    public float groundDrag = 2f;

    public float moveSpeed = 7f;
    public Transform orientation;
    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;
    Rigidbody rb;
    
    private Player _player;

    public float jumpForce;
    public float hoverSpeed;
    public float hoverPercent;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyJump = true;
    public KeyCode jumpKey = KeyCode.Space;
    
    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Jump()
    {
        // rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        // rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        Vector3 pos = transform.position;
        float newY = (hoverPercent * Mathf.Sin(Time.time * hoverSpeed)) + playerHeight;
        transform.position = new Vector3(pos.x, newY, pos.z);
    }

    private void ResetJump()
    {
        readyJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        onGround = Physics.Raycast(transform.position, Vector3.down, playerHeight + 0.5f + 0.2f, whatIsGround);
        MyInput();
        SpeedControl();

        if (onGround)
        {
            rb.drag = groundDrag;
            Vector3 pos = transform.position;
            float newY = (hoverPercent * Mathf.Sin(Time.time * hoverSpeed)) + playerHeight;
            transform.position = new Vector3(pos.x, newY, pos.z);
        }
        else
        {
            rb.drag = 0;
        }
    }

    private void FixedUpdate()
    {
        if (_player.user){
            MovePlayer();
        }
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(jumpKey) && readyJump)
        {   
            Debug.Log("Ini Jump");
            readyJump = false;
            
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if (onGround)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }

        else if (!onGround)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}

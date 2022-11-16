using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public RigidBody rb;

    public float runSpeed = 200f;
    public float strafeSpeed = 500f;
    public float jumpForce = 15;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;

    void Update()
    {
        
    }
}

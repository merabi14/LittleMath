using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    public float forwardForce= 300;
    public float sidewaysForce = 350;

    private float horizontal;

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3 ((sidewaysForce * horizontal) * Time.deltaTime, rb.velocity.y,forwardForce * Time.deltaTime);
    }
}

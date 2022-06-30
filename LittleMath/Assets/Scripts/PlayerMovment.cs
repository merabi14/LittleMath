using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    public float forwardForce= 700;
    public float sidewaysForce = 780;

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

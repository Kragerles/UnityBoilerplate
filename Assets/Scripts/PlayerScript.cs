using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = _rb.linearVelocity;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            _rb.linearVelocity = new Vector3(3f, vel.y, vel.z);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.linearVelocity = new Vector3(-3f, vel.y, vel.z);
        }
        if(Input.GetKey(KeyCode.Space) && _rb.linearVelocity.y == 0)
        {
            _rb.linearVelocity = new Vector3(vel.x, 7f, vel.z);
        }
    }
}
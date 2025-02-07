using UnityEngine;

// Controls player movement & rotation
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 90.0f;
    private Rigidbody rb;

    void Start()
    {
        // Assign the Rigidbody component in the Start method
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // No need to assign rb here, it's already assigned in Start
    }

    void FixedUpdate()
    {
        // Getting keyboard input and storing in a variable
        float moveVertical = Input.GetAxis("Vertical");
        // Calculate movement vector
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        // Debug.Log(movement); // Uncomment if you want to debug the movement vector
        rb.MovePosition(rb.position + movement);

        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
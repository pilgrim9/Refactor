using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    /*---- Ordena el C�dgo  ----*/

    public float movementSpeed;
    public float jumpForce;
    public float rotationSpeed = 10;

    bool isJumping;
    Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float yMovement = _rigidbody2D.velocity.y;
        float xMovement = Input.GetAxis("Horizontal");
        _rigidbody2D.velocity = new Vector2(xMovement * movementSpeed, yMovement) ;
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation = Quaternion.Euler(0, 0, Time.deltaTime * rotationSpeed);
        }
        if (Input.GetButton("Jump") && !isJumping)
        {
            _rigidbody2D.AddForce(Vector2.up * jumpForce);
            isJumping = true;
        }
    }
}
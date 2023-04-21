using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    Vector2 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        /*controls = new PlayerAct();
        controls.Enable();
        controls.Player.Move.performed += ctx =>
        {
            Vector2 v = ctx.ReadValue<Vector2>();
            moveDirection.x = v.y;
            moveDirection.y = v.x;
        };*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
    }

    protected void Movement()
    {
        if(Input.GetKeyDown((KeyCode.W)) == true){
            
        }
        //rb.AddForce(5 * speed * moveDir.x * transform.forward, ForceMode.Force);
        //rb.AddForce(5 * speed * moveDir.y * transform.right, ForceMode.Force);

    }
}

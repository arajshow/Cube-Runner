using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 10f;
    public float force = 1000f;
    public float minX;
    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bodyPostion = transform.position;
        //if(bodyPostion.x < minX)
        //{
        //    bodyPostion.x = minX;
        //}
        //else if(bodyPostion.x > maxX)
        //{
        //    bodyPostion.x = maxX;
        //}
        bodyPostion.x = Mathf.Clamp(bodyPostion.x, minX, maxX);
        transform.position = bodyPostion;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed*Time.deltaTime, 0, 0);
            //rb.AddForce(2000f*Time.deltaTime,0 ,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed*Time.deltaTime, 0, 0);
            //rb.AddForce(2000f * Time.deltaTime, 0, 0);
        }
        //rb.AddForce(0,0,1000f*Time.deltaTime);

    }

    private void FixedUpdate()
    {
        rb.AddForce(0,0,force*Time.deltaTime);

    }
}

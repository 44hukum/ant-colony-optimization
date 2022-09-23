using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed=10.0f;
    private float turnspeed = 10.0f;
    private float horizontainput;
    private float verticalinput;
    private int weight = 0;
    private Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void FixedUpdate() {
        horizontainput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");

        //hello world how are you
        transform.Translate(Vector3.forward * Time.deltaTime * speed* verticalinput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontainput);

        if (weight == 0) {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
             
       
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        //collectables for agents
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Pickedup the resources");
            transform.Rotate(0, 180, 0);

        }
        if (other.gameObject.CompareTag("Start"))
        {
            Debug.Log("Missed it");
            transform.Translate(0, 0, 0);
            transform.Rotate(0, 180, 0);
            weight = 1;

        }


    }

    //counter for methods to remember the source

}

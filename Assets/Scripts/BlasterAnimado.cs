using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterAnimado : MonoBehaviour
{
    public float maxspeed = 100f;
    public Rigidbody rig;

    /*private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }*/
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = transform.position + transform.forward * maxspeed; // ESTO PERMITE MOVITMIENTO DEL DISPARO, AÚN ESTOY DEFINIENDOLO BIEN

    }

    
    void Update()
    {
        //rig.velocity = transform.forward * maxspeed;
        //rig.velocity = transform.position * maxspeed;
    }

    private void FixedUpdate()
    {
        Vector2 OrigenDeTiro = transform.position;

        //rig.velocity = transform.forward * maxspeed;

        

        //r2d = new Vector3(maxspeed * Time.deltaTime, 0);
        
        /*Vector3 OrigenDeTiro = transform.position;

        Vector3 velocity = new Vector3(maxspeed * Time.deltaTime, 0, 0);
        
        OrigenDeTiro += transform.forward;
        //transform.forward = OrigenDeTiro;*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterAnimado : MonoBehaviour
{
    public float maxspeed = 100f;
    public Rigidbody rig;
        

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = transform.right * maxspeed; // ESTO PERMITE MOVITMIENTO DEL DISPARO, AÚN ESTOY DEFINIENDOLO BIEN
                                                    // AHI DESCUBRI QUE EL 'forward' HACIA QUE EL TIRO INCREMENTE EN EL EJE Z, ENTONCES LO CAMBIÉ A '.right'

    }
        
    void Update()
    {
        Destroy(gameObject, 8f);
    }
        

}

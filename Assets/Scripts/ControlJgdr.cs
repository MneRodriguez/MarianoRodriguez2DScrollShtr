using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJgdr : MonoBehaviour
{
    //public Sprite spriteR;

    float maxSpeed = 40f;
    void Start()
    {
        //spriteR = gameObject.GetComponent<Sprite>();
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") *maxSpeed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
                
        transform.position = pos;

        /*float MoverHorizontal = 
        float MoverVertical = Input.GetAxis("Vertical");

        Vector2 movto = new Vector2(MoverHorizontal, MoverVertical);*/
                
    }
}

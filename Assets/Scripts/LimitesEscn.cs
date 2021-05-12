using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitesEscn : MonoBehaviour
{
    private Vector2 screenBoundaries;
    public float JgdrWidth;
    public float JgdrHeight;
    
    void Start()
    {
        screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        JgdrWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x;
        JgdrHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y;
    }

    
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBoundaries.x + JgdrWidth, screenBoundaries.x * -1 - JgdrWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBoundaries.y + JgdrWidth, screenBoundaries.y * -1 - JgdrHeight);
        
        transform.position = viewPos;
    }
}

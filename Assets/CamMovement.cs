using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0))
        {
            Vector3 direction = startPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 pos = Camera.main.transform.position;
            pos.x += direction.x;
            Camera.main.transform.position = pos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Limit the player movement
    public float xPosLim;
    public float xNegLim;
    
    private bool isMove = false;
    private bool isFungusShows = false;
    private float target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            if (!isMove) isMove = true;
        }
        if (isMove && !isFungusShows)
        {
            Vector3 pos = transform.position;
            if (target >= xPosLim) target = xPosLim;
            if (target <= xNegLim) target = xNegLim;
            pos.x = Mathf.MoveTowards(transform.position.x, target, speed * Time.deltaTime);
            transform.position = pos;
        }
    }

    void SetPlayerAvailability()
    {
        if (!isFungusShows) isFungusShows = true;
        else isFungusShows = false;
    }
}

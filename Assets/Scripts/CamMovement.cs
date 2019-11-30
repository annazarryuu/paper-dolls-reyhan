using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startPos;
    public float xLeftMost;
    public float xRightMost;
    private bool isFungusShows = false;
    private float minArea;
    private float maxArea;

    private float camHeight;
    private float camWidth;

    [SerializeField]
    GameObject environment;
    void Start()
    {
        minArea = environment.GetComponent<SpriteRenderer>().bounds.min.x;
        maxArea = environment.GetComponent<SpriteRenderer>().bounds.max.x;

        camHeight = 2f * Camera.main.orthographicSize;
        camWidth = camHeight * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 initPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (!isFungusShows)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 direction = startPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 pos = Camera.main.transform.position;
                pos.x += direction.x;
                if (pos.x - camWidth / 2 <= minArea) pos.x = minArea + camWidth/2;
                if (pos.x + camWidth / 2 >= maxArea) pos.x = maxArea - camWidth/2;
                Camera.main.transform.position = pos;
               // Debug.Log("B: " + Camera.main.transform.pos);
            }
        }
    }

    void SetCameraAvailability()
    {
        if (!isFungusShows) isFungusShows = true;
        else isFungusShows = false;
    }
}

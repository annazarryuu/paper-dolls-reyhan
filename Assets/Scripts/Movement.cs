using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Limit the player movement
    public float xPosLim;
    public float xNegLim;

	private Animator anim;
    private bool isMove = false;
    private bool isFungusShows = false;
    private float target;
	private Vector3 faceRight;
	private Vector3 faceLeft;
	// Start is called before the first frame update
	void Start()
    {
		anim = GetComponent<Animator>();
		faceLeft = new Vector3(-0.485f, 0.485f, 0.485f);
		faceRight = new Vector3(0.485f, 0.485f, 0.485f);
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            anim.SetBool("isMoving", true);
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            if (!isMove && !isFungusShows)
            {
                isMove = true;
            }
        }
        if (isMove)
        {
            Vector3 pos = transform.position;
            if (target >= xPosLim) target = xPosLim;
            if (target <= xNegLim) target = xNegLim;
			if (target < transform.position.x) transform.localScale = faceLeft;
			else if (target > transform.position.x) transform.localScale = faceRight;
			pos.x = Mathf.MoveTowards(transform.position.x, target, speed * Time.deltaTime);
            transform.position = pos;
            if (pos.x == target) isMove = false;
        }
        anim.SetBool("isMoving", isMove);
	}

    void SetPlayerAvailability()
    {
        if (!isFungusShows) isFungusShows = true;
        else isFungusShows = false;
    }
}

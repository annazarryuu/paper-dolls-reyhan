using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaraEncounter2nd : MonoBehaviour
{
    [SerializeField]
    DecisionManager dm;

    [SerializeField]
    GameObject reyhan;

    int counter = 0;
    bool touch = false;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        dm = new DecisionManager().get();
        bool b = dm.getBlackmailStatus();
        print(b);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                touch = true;
            }

        }

        if(counter == 0 && touch && Vector3.Distance(hit.collider.gameObject.transform.position, reyhan.transform.position) <= 1.5)
        {
            Fungus.Flowchart.BroadcastFungusMessage("no blackmail");
            counter++;
        }
    }
}

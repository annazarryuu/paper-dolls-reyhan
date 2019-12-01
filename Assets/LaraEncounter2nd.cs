using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaraEncounter2nd : MonoBehaviour
{
    [SerializeField]
    DecisionManager dm;

    // Start is called before the first frame update
    void Start()
    {
        bool b = dm.getBlackmailStatus();
        print(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

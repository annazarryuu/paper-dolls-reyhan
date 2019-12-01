using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionManager : MonoBehaviour
{
    // Start is called before the first frame update

    private bool blackmail;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void chooseBlackmail()
    {
        blackmail = true;
    }
    void chooseBlackmailNot()
    {
        blackmail = false;
    }
}

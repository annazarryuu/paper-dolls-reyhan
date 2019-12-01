using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static DecisionManager dm;
    private bool blackmail;

    void Start()
    {
        if(dm == null)
        {
            dm = new DecisionManager();
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public DecisionManager get()
    {
        return this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChooseBlackmail()
    {
        blackmail = true;
    }

    void ChooseBlackmailNot()
    {
        blackmail = false;
    }

    public bool getBlackmailStatus()
    {
        return this.blackmail;
    }
}

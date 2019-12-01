using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static DecisionManager dm = null;
    private static bool blackmail;

    public DecisionManager()
    {

    }

    void Start()
    {
        if (dm == null)
        {
            DontDestroyOnLoad(this.gameObject);
            dm = new DecisionManager().get();
        }
    }

    public DecisionManager get()
    {
        if (dm == null)
        {
            Debug.Log("Test A");
            dm = new DecisionManager();
        }
        return dm;
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
        return blackmail;
    }
}

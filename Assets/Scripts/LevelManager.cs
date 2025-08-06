using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager lm;
    public static int test;

    void Awake()
    {
        lm = GetComponent<LevelManager>();

        GameObject uiObject = new GameObject("UI");
        uiObject.AddComponent<UIscript>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAT : MonoBehaviour
{
    string A;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        A = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(A);
        Debug.Log("ABC");
    }
}

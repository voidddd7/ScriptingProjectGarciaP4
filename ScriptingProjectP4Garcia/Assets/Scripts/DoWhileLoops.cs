using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");
        } while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour
{
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);

    }

    void Example(int pens, int crayons)
    {
        int answers;
        answers = pens * crayons * alpha;
        Debug.Log(answers);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " +  alpha);
    }
}

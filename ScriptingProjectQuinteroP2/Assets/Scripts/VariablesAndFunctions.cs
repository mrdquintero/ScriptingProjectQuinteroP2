using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Creating an integer variable to hold a value
    int myInt = 7;

    // Start is called before the first frame update
    void Start()
    {
        //change the value of myInt variable by running the MultiplyByTwo Function
        myInt = MultiplyByTwo(myInt); 
        Debug.Log(myInt);
    }   
    
    //creating a function to mulitplly a passed vlaue by another value
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2; 
        return result;
    }

    // Update is called once per frame
    void Update() 
    {
    }
}

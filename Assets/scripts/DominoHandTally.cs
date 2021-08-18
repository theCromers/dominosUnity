using UnityEngine;
using System.Collections;
using System;

public class DominoHandTally : MonoBehaviour
{

    //initializes each game object in game
    //since only initializes, must drag-drop
    //game objects into field of Inpspector
    GameObject dom1;
    GameObject dom2;
    GameObject dom3;
    GameObject dom4;


    // gateway method used at initialization
    void Start()
    {
       


        //Uncomment if not using drag and drop assignment
        dom1 = GameObject.Find("Domino_2-5");
        dom2 = GameObject.Find("Domino_3-1");
        dom3 = GameObject.Find("Domino_4-6");
        dom4 = GameObject.Find("Domino_5-4");

        //invokes method
        TallyHand();
    }

    //YOUR HOMEWORK SOLUTION GOES BELOW

    //
    void TallyHand()
    {
        Debug.Log("Hi from TallyHand().");
        //print("Hi from TallyHand()."); //does not always work

        //declare temporary variable to hold sum
        int sumL;
        int sumR;
        int sumFinal;
        //initialize sum to zero
        sumL = 0;
        sumR = 0;
        //get value of left sides of dominos and add to sum
        Debug.Log("dom1 value for NumLeft: " + dom1.GetComponent<Domino>().NumLeft);
        Debug.Log("dom2 value for NumLeft: " + dom2.GetComponent<Domino>().NumLeft);
        Debug.Log("dom3 value for NumLeft: " + dom3.GetComponent<Domino>().NumLeft);
        Debug.Log("dom4 value for NumLeft: " + dom4.GetComponent<Domino>().NumLeft);
        sumL = dom1.GetComponent<Domino>().NumLeft + dom2.GetComponent<Domino>().NumLeft + dom3.GetComponent<Domino>().NumLeft + dom4.GetComponent<Domino>().NumLeft;
        //get value of right side of domino and add to sum
        Debug.Log("dom1 value for NumRight: " + dom1.GetComponent<Domino>().NumRight);
        Debug.Log("dom2 value for NumRight: " + dom2.GetComponent<Domino>().NumRight);
        Debug.Log("dom3 value for NumRight: " + dom3.GetComponent<Domino>().NumRight);
        Debug.Log("dom4 value for NumRight: " + dom4.GetComponent<Domino>().NumRight);
        sumR = dom1.GetComponent<Domino>().NumRight + dom2.GetComponent<Domino>().NumRight + dom3.GetComponent<Domino>().NumRight + dom4.GetComponent<Domino>().NumRight;
        //print to console sum with string label "sum of dominos: "
        sumFinal = sumL + sumR;
        Debug.Log("sum of dominos: " + sumFinal);
    }
}

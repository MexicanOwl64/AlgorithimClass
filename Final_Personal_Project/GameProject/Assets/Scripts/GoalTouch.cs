using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detect when the ball touches to goal to show a win message
/// </summary>
public class GoalTouch : MonoBehaviour
{

   
    
    public GameObject Player;
    
    private void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched Trigger");

        if (collision.tag == "Player" )
        {
         

            Debug.Log("You touched the goal");
        }
    }
}


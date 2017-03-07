using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldier : MonoBehaviour {

    public float Health=100;
    public float Attack;
    public float Defence;
    public bool iscoliding=false;
    

    private SpriteRenderer rederer;

    public Mind themind;
     
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnTurn();
        }
    }

    public void OnTurn()
    {
        themind.updatesoldier(this);
    }

    public void atack()
    {
        Debug.Log("attack");
        iscoliding = false;
    }

    public void move ()
    {

        Debug.Log("move");
    }

    public void stay()
    {
        Debug.Log("stay");
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        iscoliding = true;
        
    }
}

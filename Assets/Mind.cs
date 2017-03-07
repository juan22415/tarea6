using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mind : MonoBehaviour
{
    private static Mind instance;

    public static Mind Instance
    {
        get
        {
            return Instance;
        }
    }

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else

            instance = this;
    }
	
	void Update () {
		
	}

    public void updatesoldier (soldier activesoldier)
    {
        if (activesoldier.iscoliding == true)
        {
            activesoldier.atack();

        }

        else

            activesoldier.move();

    }
}

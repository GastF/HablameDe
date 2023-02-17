using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{

    public LoseCondition loseCondition;


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("ESTAN PASANDO COSAS");
        if(loseCondition.timeLeft < 90)
        {
            loseCondition.timeLeft += 30f;
            Destroy(this.gameObject);

        }
        else { Destroy(this.gameObject); }
        
    }



    
    
}

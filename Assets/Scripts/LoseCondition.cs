using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    public float timeLeft = 90;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Light>().spotAngle = timeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= (Time.deltaTime * 5);
        GetComponent<Light>().spotAngle = timeLeft;
        if (timeLeft <= 0)
        {
            //do somet$$anonymous$$ng
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("gg");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   
    public Vector3 offset = new Vector3(-43.58f, 1.63f , -5.25f);
    public GameObject player;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

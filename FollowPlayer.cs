using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    //If we set private our camera we wouldn't have that GObject reference anymore.
    public GameObject player;
    private Vector3 offset = new(0, 5, -8);


    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the player by adding's to the player position
        transform.position = player.transform.position + offset;
        
    }
}

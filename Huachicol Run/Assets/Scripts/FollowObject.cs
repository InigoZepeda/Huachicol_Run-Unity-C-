using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{

    public Transform objectToFollow;
    public bool isFollowing;
    public bool followX;
    public bool followY;
    public Vector2 offset;
    public Vector2 minClamp;
    public Vector2 maxClamp;

    // Update is called once per frame
    void Update() {

        if (isFollowing)
        {
            float xPosition;
            float yPosition;

            if (followX)
            {
                xPosition = objectToFollow.position.x;
            }
            else
            {
                xPosition = transform.position.x;
            }

            if(followY)
            {
                yPosition = objectToFollow.position.y + offset.y;
            }
            else
            {
                yPosition = transform.position.y;
            }

            xPosition = Mathf.Clamp(xPosition, minClamp.x, maxClamp.x);
            yPosition = Mathf.Clamp(yPosition, minClamp.y, maxClamp.y);

            transform.position = new Vector3(xPosition, yPosition, transform.position.z);
            
        }
        
    }
}

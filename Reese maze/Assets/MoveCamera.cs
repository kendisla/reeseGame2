using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
  GameObject player;
/* this is your player object, we’ll initialize the variable in Start */

    	public float upperBound;
    	public float lowerBound;
    	public float leftBound;
    	public float rightBound;
/* these are the four bounds for your camera’s range of motion, move your camera in Unity while checking your camera view to figure out what your bounds should be (upper and lower are based the position’s y value, left and right are based on the position’s x value) */

    	float xOffset;
    	float yOffset;
/* these are the offsets between your camera’s position and the player’s in x and y values */

    	void Start()
    	{
        		player = GameObject.FindGameObjectWithTag("Player");
// this initializes your player object to the gameObject tagged “Player”

        		xOffset = transform.position.x - player.transform.position.x;
        		yOffset = transform.position.y - player.transform.position.y;
		float newX = transform.position.x;
		float newY = transform.position.y;
		if(newX < leftBound) {
			newX = leftBound;
		}else if(newX > rightBound) {
			newX = rightBound;
		}
		if(newY > upperBound) {
			newY = upperBound;
		}else if(newY < lowerBound) {
			newY = lowerBound;
		}
		transform.position = new Vector3(newX, newY, transform.position.z);
   	}

    	void Update()
    	{
        		float newX = player.transform.position.x + xOffset;
        		float newY = player.transform.position.y + yOffset;

        		if (newX > leftBound && newX < rightBound)
        		{
            		transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        		}
       		if(newY < upperBound && newY > lowerBound)
        		{
            		transform.position = new Vector3(transform.position.x, newY, transform.position.z);
       	}
}
}

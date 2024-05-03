using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowHero : MonoBehaviour
{
    public Transform heroTransform; // Reference to the hero's Transform
    public float followDistance = 0.5f; // Distance at which the gun should start following

    private bool isFollowing = false; // Flag to track if the gun is following

    private void Start()
    {
        // Ensure the heroTransform is assigned in the Inspector
       
    }

    private void Update()
    {
        // Calculate the distance between the gun and the hero
        float distance = Mathf.Abs(transform.position.x - heroTransform.position.x);

        // Check if the hero is within the followDistance
        if (distance <= followDistance && !isFollowing)
        {
            // Flip the gun's local scale to make it follow the hero
            Vector3 newScale = transform.localScale;
            newScale.x *= -1f; // Flip the X scale to reverse the gun's direction
            transform.localScale = newScale;

            isFollowing = true; // Set the flag to indicate that the gun is following
        }
        else if (distance > followDistance && isFollowing)
        {
            // If the hero moves away, reset the gun's local scale
            Vector3 newScale = transform.localScale;
            newScale.x = Mathf.Abs(newScale.x); // Reset the X scale
            transform.localScale = newScale;

            isFollowing = false; // Reset the following flag
        }
    }
}

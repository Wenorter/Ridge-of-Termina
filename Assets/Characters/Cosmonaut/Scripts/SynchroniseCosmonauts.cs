using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SynchroniseCosmonauts : MonoBehaviour
{
    public GameObject targetObject;
    private Vector3 lastPosition;
    private float timeSinceLastMove;
    private float still_frame_counter;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = targetObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if (targetObject != null){
            // If the target has moved since the last frame, change the animation controller and disable targetObject
            if (targetObject.transform.position == lastPosition)
            {
                still_frame_counter += 1;
                if (still_frame_counter > 5)
                {
                    this.transform.position = targetObject.transform.position;
                    this.transform.rotation = targetObject.transform.rotation;
                    this.transform.localScale = targetObject.transform.localScale;
                    targetObject.SetActive(false);
                }
            }
            else
            {
                still_frame_counter=0;
            }

            // Update the last position to the current position
            lastPosition = targetObject.transform.position;
        }
    }

}

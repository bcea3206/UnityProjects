using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    //movement axis and movement distance for computing open and closed positions
    public Vector3 movementAxis;
    public float distance;

    //open and closed positions of this door
    private Vector3 openPos;
    private Vector3 closedPos;

    //the amount of frames the door open animation should take
    public float frames;

    private void Start()
    {
        //Assume the door starts closed. how would you fix this if you can't make this assumption?
        closedPos = transform.position;
        openPos = closedPos + (movementAxis * distance);
    }

    public void CloseGate()
    {
        StopAllCoroutines();
        StartCoroutine(DoorMove(transform.position, closedPos, 1 /frames));
    }

    public void OpenGate()
    {
        StopAllCoroutines();
        StartCoroutine(DoorMove(transform.position, openPos, 1 / frames)); //What's the bug here, can you solve it?
    }

    IEnumerator DoorMove(Vector3 startPos, Vector3 endPos, float step)
    {
        for (float i = 0; i <= 1f; i += step)
        {
            Vector3 newPos = Vector3.Lerp(startPos, endPos, i);
            transform.position = newPos;
            yield return null;
        }
    }
  
}



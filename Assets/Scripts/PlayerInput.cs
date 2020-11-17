using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
  public static Vector3 getDirection(float acceleration, float maxVel, Vector3 currentVel)
  {
    float x = currentVel.x;
    float y = currentVel.y;
    x = Input.GetAxis("Horizontal") * acceleration;
    return new Vector3(x * Time.deltaTime, y * Time.deltaTime, 0);
  }
}

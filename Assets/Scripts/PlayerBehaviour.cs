using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
  float acceleration = 1.5f;
  float maxVel = 3.0f;
  public float gravity = -0.2f;
  Vector3 currentVel = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      currentVel = PlayerInput.getDirection(acceleration, maxVel, currentVel);
      currentVel.y += gravity;
      transform.position += currentVel;
    }

    void OnCollisionEnter(Collision collision)
    {
      Debug.Log("collided");
      currentVel.y = 0;
    }
}

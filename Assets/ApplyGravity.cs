using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyGravity : MonoBehaviour
{
  public float spY = 0;
  float gravity;
  GameObject world;
  WorldProperties worldProperties;

  // Start is called before the first frame update
  void Start()
  {
    world = transform.parent.gameObject;
    worldProperties = world.GetComponent<WorldProperties>();
    gravity = worldProperties.worldGravity;
  }

  // Update is called once per frame
  void Update()
  {
    spY += gravity;
    transform.position += new Vector3(0, Time.deltaTime * spY, 0);
  }
}

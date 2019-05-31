using UnityEngine;
using UnityEngine.Serialization;

public class CameraFollow : MonoBehaviour {

  public Transform Player;

  public float smoothSpeed = 0.125f;
  public Vector3 offset;


  public void moveCamera(Player player)
  {
    Vector3 desiredPosition = Player.position + offset;
    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    transform.position = smoothedPosition;

    transform.LookAt(Player);
  }

  void FixedUpdate ()
  {
   moveCamera(Player);
  }

}
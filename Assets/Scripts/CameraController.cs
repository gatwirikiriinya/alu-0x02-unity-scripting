using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameraOffset = new Vector3(0f, 5f, -10f); 

    private void LateUpdate()
    {
        if (player != null)
        {
            // Update the camera position relative to the player
            transform.position = player.transform.position + cameraOffset;
        }
    }
}
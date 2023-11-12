using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}

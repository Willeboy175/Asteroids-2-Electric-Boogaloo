using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    float cameraSpeed = 1f;
    [SerializeField]
    Rigidbody2D mainCamera;
    [SerializeField]
    Transform player;
    Vector2 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos.x = player.position.x - mainCamera.position.x;
        cameraPos.y = player.position.y - mainCamera.position.y;

        mainCamera.velocity = cameraPos * cameraSpeed;
    }
}

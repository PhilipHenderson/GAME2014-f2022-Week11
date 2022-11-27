using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum PlatformDirection
{
    HORIZONTAL,
    VERTICAL,
    DIAGONAL_UP,
    DIAGONAL_DOWN,
    CUSTOM
};

public class MovingPlatformController : MonoBehaviour
{
    public PlatformDirection direction;

    [Header("Movement Properties")]
    [Range(1.0f, 20.0f)]
    public float horizontalDistance = 8.0f;
    [Range(1.0f, 20.0f)]
    public float horizontalSpeed = 3.0f;
    [Range(1.0f, 20.0f)]
    public float verticalDistance = 8.0f;
    [Range(1.0f, 20.0f)]
    public float verticalSpeed = 3.0f;


    private Vector2 startPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        switch (direction)
        {
            case PlatformDirection.HORIZONTAL:
                transform.position 
                    = new Vector2(Mathf.PingPong(horizontalSpeed * Time.time, horizontalDistance) + startPoint.x, 
                    startPoint.y);
                break;
            case PlatformDirection.VERTICAL:
                break;
            case PlatformDirection.DIAGONAL_UP:
                break;
            case PlatformDirection.DIAGONAL_DOWN:
                break;
            case PlatformDirection.CUSTOM:
                break;
        }
    }
}

using UnityEngine;

public class HorizontalParallax : MonoBehaviour
{
    public enum Direction { Left, Right, Up, Down };

    [Header("Properties")]
    public float parallaxAmount = 0.9f;
    public Direction parallaxDirection = Direction.Left;

    [Header("State")]
    [SerializeField]
    private Transform cameraTransform;

    private Vector3 lastPosition;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastPosition = cameraTransform.position;
    }

    void Update()
    {
        float deltaY = (cameraTransform.position.y - lastPosition.y) * parallaxAmount;
        float direction = parallaxDirection == Direction.Left || parallaxDirection == Direction.Down ? 1.0f : -1.0f;

        if (deltaY != 0.0f)
        {
            if (parallaxDirection == Direction.Left || parallaxDirection == Direction.Right)
            {
                transform.Translate(new Vector3(deltaY * direction, 0.0f, 0.0f));
            }
            else
            {
                transform.Translate(new Vector3(0.0f, deltaY * direction, 0.0f));
            }

        }

        lastPosition = cameraTransform.position;
    }
}

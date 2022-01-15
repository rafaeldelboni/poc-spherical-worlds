using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    
    private Transform targetParent;

    private void Awake()
    {
        targetParent = target.parent;
    }

    void FixedUpdate ()
    {
        Vector3 desiredPosition = target.position;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
		
        transform.LookAt(targetParent.transform, targetParent.transform.up);
    }
}
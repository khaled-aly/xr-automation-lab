using UnityEngine;
using UnityEngine.InputSystem;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float spinSpeed = 90f;
    [SerializeField] private float bobHeight = 0.5f;
    [SerializeField] private float bobSpeed = 2f;

    private Vector3 startPos;
    private bool spinning = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
            spinning = !spinning;

        if (spinning)
            transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f);

        float y = Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        transform.position = startPos + new Vector3(0f, y, 0f);
    }
}
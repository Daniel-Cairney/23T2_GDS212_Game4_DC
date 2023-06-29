using UnityEngine;

public class Scroller : MonoBehaviour
{
   [SerializeField] private float speed = 4f;
   [SerializeField] private Vector3 StartPosition;

    private void Start()
    {
        StartPosition = transform.position;
    }

    private void Update()
    {
        transform.Translate(translation: Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -10f)
        {
            transform.position = StartPosition;
        }
    }
}
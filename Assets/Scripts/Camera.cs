using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Ball.transform.position.x, Ball.transform.position.y, transform.position.z);
    }
}

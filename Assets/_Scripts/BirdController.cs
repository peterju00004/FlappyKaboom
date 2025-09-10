using System.Numerics;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float speed = 0.5f;
    private UnityEngine.Vector2 initialPosition;

    void Start()
    {
        Debug.Log("BirdController script is running");
        initialPosition = gameObject.transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            UnityEngine.Vector2 pos = new UnityEngine.Vector2(gameObject.transform.position.x + speed, gameObject.transform.position.y);
            gameObject.transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            UnityEngine.Vector2 pos = new UnityEngine.Vector2(gameObject.transform.position.x - speed, gameObject.transform.position.y);
            gameObject.transform.position = pos;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            UnityEngine.Vector2 pos = new UnityEngine.Vector2(gameObject.transform.position.x, gameObject.transform.position.y - speed);
            gameObject.transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            UnityEngine.Vector2 pos = new UnityEngine.Vector2(gameObject.transform.position.x, gameObject.transform.position.y + speed);
            gameObject.transform.position = pos;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.transform.position = initialPosition;
        }
    }
}

using UnityEngine;

public class SquareController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    public float scaleSpeed = 0.5f;

    void Update()
    {
        // Movement
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(moveX * moveSpeed * Time.deltaTime, moveY * moveSpeed * Time.deltaTime, 0);

        // Rotation
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime);

        // Scaling
        if (Input.GetKey(KeyCode.UpArrow))
            transform.localScale += new Vector3(scaleSpeed * Time.deltaTime, scaleSpeed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.localScale -= new Vector3(scaleSpeed * Time.deltaTime, scaleSpeed * Time.deltaTime, 0);

        // Color change
        if (Input.GetKeyDown(KeyCode.R))
            GetComponent<SpriteRenderer>().color = Color.red;
        if (Input.GetKeyDown(KeyCode.G))
            GetComponent<SpriteRenderer>().color = Color.green;
        if (Input.GetKeyDown(KeyCode.B))
            GetComponent<SpriteRenderer>().color = Color.blue;
    }
}

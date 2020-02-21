using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 startingPos;
    private float speed = 3;
    private bool isBackGround;
    private float repeatwidth;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
        if (gameObject.CompareTag("Background"))
        {
            isBackGround = true;
            repeatwidth = 3.8f;
        }
        else if (gameObject.CompareTag("Level"))
        {
            isBackGround = false;
            repeatwidth = 0.96f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < startingPos.x - repeatwidth)
        {
            transform.position = startingPos;
        }
    }
}

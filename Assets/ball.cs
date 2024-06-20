using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;

    public float speed = 6f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        SendBallinRandomDirection();
    }

    private void SendBallinRandomDirection()
    {
        rigidbody2d.velocity = Vector3.zero;
        rigidbody2d.isKinematic = true;
        transform.position = Vector3.zero;
        rigidbody2d.isKinematic = false;
        
        Vector2 newBallVector = new Vector2();
        newBallVector.x = Random.Range(-1f, 1f);
        newBallVector.y = Random.Range(-1f, 1f);
        rigidbody2d.velocity = newBallVector * speed;
    }
// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SendBallinRandomDirection();
        }
    }
    
   
}

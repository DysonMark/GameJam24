using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBox : MonoBehaviour
{
    public float speed = 2;
    public bool MoveTheBox = false;
    // public Rigidbody2D freezePlayer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MoveTheBox = true;
        }
        if (MoveTheBox == true)
        {
            //freezePlayer.constraints = RigidbodyConstraints2D.FreezePositionX;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();
        repeatWidth = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < -repeatWidth)
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        //transform.position = new Vector2 (repeatWidth, transform.position.y);
        transform.Translate (new Vector3 (2 * repeatWidth, 0f, 0f));
    }
}

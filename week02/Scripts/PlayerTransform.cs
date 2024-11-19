using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    float speed;
    float x;
    float y;
    public Vector3 limitMax;
    public Vector3 limitMin;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        speed = 0.1f;
        float x = Input.GetAxis("Horizontal") * speed;
        float y = Input.GetAxis("Vertical") * speed;

        transform.Translate(new Vector3(x,y,0));

        if(transform.position.x > limitMax.x)
        {
            temp.x = limitMax.x;
            temp.y = transform.position.y;
            transform.position = temp;
        }
        if(transform.position.y > limitMax.y)
        {
            temp.y = limitMax.y;
            temp.x = transform.position.x;
            transform.position = temp;
        }
        if(transform.position.x < limitMax.x)
        {
            temp.x = limitMax.x;
            temp.y = transform.position.y;
            transform.position = temp;
        }
        if(transform.position.y < limitMax.y)
        {
            temp.y = limitMax.y;
            temp.x = transform.position.y;
            transform.position = temp;
        }   
    }


    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawLine(limitMin, new Vector2(limitMax.x, limitMin.y));
        Gizmos.DrawLine(limitMin, new Vector2(limitMin.x, limitMax.y));
        Gizmos.DrawLine(limitMax, new Vector2(limitMax.x, limitMin.y));
        Gizmos.DrawLine(limitMax, new Vector2(limitMin.x, limitMax.y));

    }
}

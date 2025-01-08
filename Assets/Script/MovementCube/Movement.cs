using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    int count = 0;
    public void moveUp()
    {
        transform.position += transform.forward* Time.deltaTime;
    }
    public void moveDown()
    {
        transform.position -= transform.forward * Time.deltaTime;
    }
    public void moveRight()
    {
        transform.position += transform.right * Time.deltaTime;

    }
    public void moveLeft()
    {
        transform.position -= transform.right * Time.deltaTime;
    }

    public void increase()
    {
        if (count < 5)
        {
            transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
            count++;
        }
    }

    public void decrease()
    {
        if(count != 0)
        {
            transform.localScale += new Vector3(-0.1F, -0.1F, -0.1F);
            count--;
        }
        
    }
}

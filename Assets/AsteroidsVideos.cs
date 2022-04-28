using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsVideos : MonoBehaviour
{
    
    public class Teleport : MonoBehaviour
    {
        //The Wrap Around Code.
        void Update()
        {
            if (transform.position.x > 735)
            {
                transform.position = new Vector3(-735f, 0f, transform.position.z);
            }
            if (transform.position.x < -735)
            {
                transform.position = new Vector3(735f, 0f, transform.position.z);
            }
            if (transform.position.z > 735)
            {
                transform.position = new Vector3(transform.position.x, 0f, -735f);
            }
            if (transform.position.z < -735)
            {
                transform.position = new Vector3(transform.position.x, 0f, 735f);
            }
        }
    }


}

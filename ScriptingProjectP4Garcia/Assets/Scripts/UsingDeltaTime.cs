using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3f;
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0.0f)
        {
            if (light != null)
            {
                Light lightcomponent = light.GetComponent<Light>();
                if (lightcomponent != null)
                {
                    lightcomponent.enabled = false;


                }
            }

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    float speed = 5.0F;
    float rotationSpeed = 100.0F;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0,0, translation);
        transform.Rotate(0, rotation, 0);

        if(translation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("characterSpeed", translation);
        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetFloat("characterSpeed", 0);
        }
    }
}

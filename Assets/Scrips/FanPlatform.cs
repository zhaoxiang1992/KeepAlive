using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanPlatform : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            anim.Play("Fan_run");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

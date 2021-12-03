using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float kecepatan;
    Rigidbody rb;
    Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }
    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * kecepatan;
        anim.SetFloat("MoveSpeed", Mathf.Abs(gerak), 0.1f, Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}

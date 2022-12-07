using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    [SerializeField]
    float bulletSpeed = 1f;
    [SerializeField]
    Rigidbody2D bullet;
    [SerializeField]
    float destroyTimer = 1f;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * bulletSpeed * Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > destroyTimer)
        {
            Destroy(gameObject);
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
        //Destroy(gameObject);
    //}
}

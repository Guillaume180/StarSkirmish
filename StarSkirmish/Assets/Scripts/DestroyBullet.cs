using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public float bulletTime = 3;

    // Update is called once per frame
    void Update()
    {
        if(bulletTime >= 0)
        {
            bulletTime -= Time.deltaTime;
        }

        if(bulletTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Destroy(gameObject);
    }

}

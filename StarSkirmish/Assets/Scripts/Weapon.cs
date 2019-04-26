using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public CharacterController weaponDirection;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, Quaternion.identity) as GameObject;

        if (weaponDirection.facingRight)
        {
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 10, ForceMode2D.Impulse);
        }
        else
        {
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 10, ForceMode2D.Impulse);
        }
    }
}

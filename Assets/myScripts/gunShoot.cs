using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class gunShoot : MonoBehaviour
{
    private StarterAssetsInputs _input;
    public GameObject bullet;
    public GameObject bulletPoint;

    public float bulletSpeed = 2000;
    // Start is called before the first frame update
    void Start()
    {
        var obj = GameObject.Find("PlayerCapsule");
        _input = obj.GetComponent<StarterAssetsInputs>(); // Fixed typo in GetComponent
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.shoot)
        {
            Shoot();
            _input.shoot = false;
        }
    }

    void Shoot()
    {
        Debug.Log("shoot!");
        GameObject ammo = Instantiate(bullet,bulletPoint.transform.position,transform.rotation);
        ammo.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(ammo,2);
    }
}
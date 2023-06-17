using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class DamageGun : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    private Transform PlayerCamera;


    private void Start()
    {
        PlayerCamera = Camera.main.transform;
    }

    private void Shoot()
    {
        Ray GunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);
        if (Physics.Raycast(GunRay, out RaycastHit hitInfo, BulletRange))
        {
            if (hitInfo.collider.gameObject.TryGetComponent(out Entity enemy))
            {
                enemy.Health -= Damage;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{

    public override void Shoot(Transform shootPoint)
    {
        //   Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        
        for (int i = 0; i < 3; i++)
        {
            Vector3 angle = shootPoint.eulerAngles;
            angle.z += Random.Range(-10, 10);
            Instantiate(Bullet, shootPoint.position, Quaternion.Euler(angle));
        }
    }
}

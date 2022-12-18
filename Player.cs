using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballprefab;
    public Transform attackPoint;
    private int health = 10;
    // Start is called before the first frame update
    public void  TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока:" + health);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballprefab, attackPoint.position, attackPoint.rotation);
        }
    }
}

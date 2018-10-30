﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyShip : MonoBehaviour
{
    [SerializeField] private Ship ship;
    [SerializeField] private Weapon weapon;


    public virtual void Update()
    {
        ShipLogic(Time.deltaTime);
    }

    public virtual void ShipLogic(float deltaTime)
    {
        
    }

    public virtual void Fire()
    {
        weapon.Fire();
    }

    public virtual void Damage(float damage)
    {
        ship.curent_hp -= damage;
        if (ship.curent_hp <= 0)
        {
            DestroyThis();
        }
    }

    public virtual void DestroyThis()
    {
        Destroy(gameObject);
    }

    public float ShipSpeedCalculation(float speedKof)
    {
        return speedKof * ship.speed * GameController.Incstance.SpeedKof * Time.deltaTime;
    }
}
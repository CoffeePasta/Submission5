using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBird : Bird
{
    public float _boostForce = 100;
    public bool _hasBoost = false;

    public override void OnTap()
    {
        Boost();
    }

    public void Boost()
    {
        if (State == BirdState.Thrown && !_hasBoost)
        {
            rigidBody.AddForce(rigidBody.velocity * _boostForce);
            _hasBoost = true;
        }
    }
}

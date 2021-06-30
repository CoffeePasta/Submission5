using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    private float _originRad;
    public float _explotionRadius = 10f;
    public bool _isExploded = false;

    public override void OnTap()
    {
        Explode();
    }

    public void Explode()
    {
        if (State != BirdState.Idle && !_isExploded)
        {
            _originRad = collider.radius;
            rigidBody.mass *= 5;
            collider.radius *= _explotionRadius;
            _isExploded = true;

            Invoke("Exploded", 0.05f);
        }
    }

    public void Exploded()
    {
        collider.radius = _originRad;
    }
}

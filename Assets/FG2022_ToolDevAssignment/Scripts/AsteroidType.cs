using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(menuName = "Asteroid", fileName = "Asteroid")]
    public class AsteroidType : ScriptableObject
    {

        [Range(0, 5)] public float minForce;
        [Range(0, 5)] public float maxForce;
        [Range(0, 5)] public float minSize;
        [Range(0, 5)] public float maxSize;
        [Range(0, 5)] public float minTorque;
        [Range(0, 5)] public float maxTorque;

        public Transform shape;
        public Color color;
    }
}
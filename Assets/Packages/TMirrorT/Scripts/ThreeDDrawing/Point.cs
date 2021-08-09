using System;
using UnityEditor;
using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public class Point : ThreeDDrawing
    {
        public float radius = 0.5f;

        protected override void OnDrawGizmos()
        {
            Gizmos.color = color;
            Gizmos.DrawSphere(transform.position, radius);
        }
    }
}
using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public abstract class ThreeDDrawing : MonoBehaviour
    {
        public Color color = Color.black;
        public float length = 1;

        protected virtual void OnDrawGizmos()
        {
        }
    }
}
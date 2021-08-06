using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public class Axis : MonoBehaviour
    {
        public enum AxisID
        {
            X,
            Y,
            Z
        }

        public int lenght = 10;
        public Color axisColor = Color.red;
        public AxisID axisId;

        void OnDrawGizmos()
        {
            Gizmos.color = axisColor;

            switch (axisId)
            {

                case AxisID.X:
                    Gizmos.DrawRay(transform.position, Vector3.right * lenght);
                    Gizmos.DrawRay(transform.position, -Vector3.right * lenght);
                    break;
                case AxisID.Y:
                    Gizmos.DrawRay(transform.position, Vector3.up * lenght);
                    Gizmos.DrawRay(transform.position, -Vector3.up * lenght);
                    break;
                case AxisID.Z:
                    Gizmos.DrawRay(transform.position, Vector3.forward * lenght);
                    Gizmos.DrawRay(transform.position, -Vector3.forward * lenght);
                    break;
                default:
                    break;
            }

        }

    }

}
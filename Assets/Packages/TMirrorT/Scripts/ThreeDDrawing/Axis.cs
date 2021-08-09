using UnityEngine;

namespace SMSPackages.ThreeD
{
    public enum AxisType
    {
        X,
        Y,
        Z
    }

    public class Axis : ThreeDDrawing
    {

        public AxisType axisType;

        protected override void OnDrawGizmos()
        {
            Gizmos.color = color;
            switch (axisType)
            {
                case AxisType.X:
                    Gizmos.DrawRay(transform.position, Vector3.right * length);
                    Gizmos.DrawRay(transform.position, -Vector3.right * length);
                    break;
                case AxisType.Y:
                    Gizmos.DrawRay(transform.position, Vector3.up * length);
                    Gizmos.DrawRay(transform.position, -Vector3.up * length);
                    break;
                case AxisType.Z:
                    Gizmos.DrawRay(transform.position, Vector3.forward * length);
                    Gizmos.DrawRay(transform.position, -Vector3.forward * length);
                    break;
                default:
                    break;
            }
        }

    }

}
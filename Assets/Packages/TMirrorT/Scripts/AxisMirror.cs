using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public class AxisMirror : Axis, IMirror
    {
        public float factor = 1;

        public Vector3 GetMirrorPosition(Vector3 target)
        {
            float distance = factor;

            switch (axisType)
            {
                case AxisType.X:
                    distance *= target.z - transform.position.z;
                    return new Vector3(target.x, target.y, transform.position.z - distance);
                case AxisType.Y:
                    distance *= target.y - transform.position.y;
                    return new Vector3(target.x, transform.position.y - distance, target.z);
                case AxisType.Z:
                    distance *= target.x - transform.position.x;
                    return new Vector3(transform.position.x - distance, target.y, target.z);
                default:
                    return Vector3.zero;
            }
        }

        public Quaternion GetMirrorRotation(Quaternion target)
        {
            switch (axisType)
            {
                case AxisType.X:
                    return new Quaternion(target.x, target.y, -target.z, -target.w);
                case AxisType.Y:
                    return new Quaternion(target.x, -target.y, target.z, -target.w);
                case AxisType.Z:
                    return new Quaternion(-target.x, target.y, target.z, -target.w);
                default:
                    return Quaternion.identity;
            }
        }

        public Vector3 GetMirrorScale(Vector3 target)
        {
            switch (axisType)
            {
                case AxisType.X:
                    return new Vector3(target.x, target.y, -target.z);
                case AxisType.Y:
                    return new Vector3(target.x, -target.y, target.z);
                case AxisType.Z:
                    return new Vector3(-target.x, target.y, target.z);
                default:
                    return target;
            }
        }
    }
}
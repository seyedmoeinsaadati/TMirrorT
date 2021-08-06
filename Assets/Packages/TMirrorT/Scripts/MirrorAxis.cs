using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public class MirrorAxis : Axis, IMirror
    {
        public float factor = 1;

        public Vector3 GetMirrorPosition(Vector3 targetPosition)
        {
            float distance = factor;

            switch (axisId)
            {
                case AxisID.X:
                    distance *= targetPosition.z - transform.position.z;
                    return new Vector3(targetPosition.x, targetPosition.y, transform.position.z - distance);
                case AxisID.Y:
                    distance *= targetPosition.y - transform.position.y;
                    return new Vector3(targetPosition.x, transform.position.y - distance, targetPosition.z);
                case AxisID.Z:
                    distance *= targetPosition.x - transform.position.x;
                    return new Vector3(transform.position.x - distance, targetPosition.y, targetPosition.z);
                default:
                    return Vector3.zero;
            }
        }

        public Quaternion GetMirrorRotation(Quaternion target)
        {
            switch (axisId)
            {
                case AxisID.X:
                    return new Quaternion(target.x, target.y, -target.z, -target.w);
                case AxisID.Y:
                    // don't change rotation
                    return new Quaternion(target.x, target.y, target.z, target.w);
                case AxisID.Z:
                    return new Quaternion(-target.x, target.y, target.z, -target.w);
                default:
                    return Quaternion.identity;
            }
        }
    }
}
using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public class PlaneMirror : ThreeD.Plane, IMirror
    {
        public float factor = 1;

        public Vector3 GetMirrorPosition(Vector3 target)
        {
            float distance = factor;
            switch (planeType)
            {
                case PlaneType.XY:
                    distance *= target.z - transform.position.z;
                    return new Vector3(target.x, target.y, transform.position.z - distance);
                case PlaneType.XZ:
                    distance *= target.y - transform.position.y;
                    return new Vector3(target.x, transform.position.y - distance, target.z);
                case PlaneType.ZY:
                    distance *= target.x - transform.position.x;
                    return new Vector3(transform.position.x - distance, target.y, target.z);
                default:
                    return Vector3.zero;
            }

        }

        public Quaternion GetMirrorRotation(Quaternion target)
        {
            switch (planeType)
            {
                case PlaneType.XY:
                    return new Quaternion(target.x, target.y, -target.z, -target.w);
                case PlaneType.XZ:
                    return new Quaternion(target.x, -target.y, target.z, -target.w);
                case PlaneType.ZY:
                    return new Quaternion(-target.x, target.y, target.z, -target.w);
                default:
                    return Quaternion.identity;
            }
        }

        public Vector3 GetMirrorScale(Vector3 target)
        {
            switch (planeType)
            {
                case PlaneType.XY:
                    return new Vector3(target.x, target.y, -target.z);
                case PlaneType.XZ:
                    return new Vector3(target.x, -target.y, target.z);
                case PlaneType.ZY:
                    return new Vector3(-target.x, target.y, target.z);
                default:
                    return target;
            }
        }
    }
}
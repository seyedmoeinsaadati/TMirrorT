using UnityEngine;
namespace SMSPackages.TMirrorT
{
    public class PointMirror : MonoBehaviour, IMirror
    {
        public float factor = 1f;

        public Vector3 beAxis = Vector3.one;
        public Vector4 rotaionAxis = Vector4.one;

        public Vector3 GetMirrorPosition(Vector3 targetPosition)
        {
            float x = targetPosition.x - 2 * (targetPosition.x - transform.position.x) * beAxis.x;
            float y = targetPosition.y - 2 * (targetPosition.y - transform.position.y) * beAxis.y;
            float z = targetPosition.z - 2 * (targetPosition.z - transform.position.z) * beAxis.z;
            return new Vector3(x, y, z) * factor;
        }

        public Quaternion GetMirrorRotation(Quaternion target)
        {
            //        return new Quaternion(target.x, target.y, -target.z, -target.w);
            return new Quaternion(target.x * rotaionAxis.x, target.y * rotaionAxis.y,
                                    target.z * rotaionAxis.z, target.w * rotaionAxis.w);
        }
    }
}
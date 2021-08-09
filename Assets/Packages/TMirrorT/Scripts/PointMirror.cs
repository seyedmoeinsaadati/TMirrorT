using UnityEngine;
namespace SMSPackages.TMirrorT
{
    public class PointMirror : Point, IMirror
    {
        [Header("Mirror Properties")]
        public float factor = 1f;

        [Tooltip("Lock axis with set 0 for locking axis. Use only 0 or 1 value for this feild.")]
        public Vector3 beAxis = Vector3.one;

        [Tooltip("Custom your mirror behaviour by changing mirror rotation axes")]
        public Vector4 customRotaionQuaternion = Vector4.one;

        public Vector3 GetMirrorPosition(Vector3 target)
        {
            float x = target.x - 2 * (target.x - transform.position.x) * beAxis.x;
            float y = target.y - 2 * (target.y - transform.position.y) * beAxis.y;
            float z = target.z - 2 * (target.z - transform.position.z) * beAxis.z;
            return new Vector3(x, y, z) * factor;
        }

        public Quaternion GetMirrorRotation(Quaternion target)
        {
            return new Quaternion(target.x * customRotaionQuaternion.x,
                                    target.y * customRotaionQuaternion.y,
                                    target.z * customRotaionQuaternion.z, target.w * customRotaionQuaternion.w);
        }

        public Vector3 GetMirrorScale(Vector3 target)
        {
            float x = target.x * (beAxis.x > 0 ? -1 : 1);
            float y = target.y * (beAxis.y > 0 ? -1 : 1);
            float z = target.z * (beAxis.z > 0 ? -1 : 1);
            return new Vector3(x, y, z);
        }
    }
}
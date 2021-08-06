using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public interface IMirror
    {
        Vector3 GetMirrorPosition(Vector3 targetPosition);

        Quaternion GetMirrorRotation(Quaternion target);

    }
}
using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public class Line : MonoBehaviour, IMirror
    {
        public enum Space
        {
            XY,
            XZ,
            ZY
        }

        Vector3 p1, p2;

        public float factor = 1;

        public int lenght = 10;
        public Color lineColor = Color.red;
        public Space space;

        public Vector3 GetMirrorPosition(Vector3 targetPosition)
        {
            CalculatePoints();
            // Form a unit vector in the direction of the line.
            var lineDirection = (p2 - p1).normalized;
            Vector3 perpendicular = Vector3.zero;

            // Rotate the vector 90 degrees
            // Rotate the vector 90 degrees in the XY plane
            // to get a vector perpendicular to the mirror line.
            switch (space)
            {
                case Space.XY:
                    perpendicular = new Vector3(-lineDirection.y, lineDirection.x, 0);
                    break;
                case Space.XZ:
                    perpendicular = new Vector3(-lineDirection.z, 0, lineDirection.x);
                    break;
                case Space.ZY:
                    break;
                default:
                    break;
            }

            Vector3 position = targetPosition - 2 * (Vector3.Dot((targetPosition - p1), perpendicular) * perpendicular * ((factor + 1) / 2));

            return position;
        }

        public Quaternion GetMirrorRotation(Quaternion target)
        {
            return new Quaternion(target.x, target.y, -target.z, -target.w);
        }

        public void CalculatePoints()
        {
            switch (space)
            {
                case Space.XY:
                    p1 = transform.up + transform.position;
                    p2 = -transform.up + transform.position;
                    break;
                case Space.XZ:
                    p1 = transform.forward + transform.position;
                    p2 = -transform.forward + transform.position;
                    break;
                case Space.ZY:
                    p1 = transform.up + transform.position;
                    p2 = -transform.up + transform.position;
                    break;
                default:
                    break;
            }
        }

        void OnDrawGizmos()
        {
#if UNITY_EDITOR
            CalculatePoints();
#endif
            Gizmos.color = lineColor;
            switch (space)
            {

                case Space.XY:
                    Gizmos.DrawRay(transform.position, transform.up * lenght);
                    Gizmos.DrawRay(transform.position, -transform.up * lenght);
                    break;
                case Space.XZ:
                    Gizmos.DrawRay(transform.position, transform.forward * lenght);
                    Gizmos.DrawRay(transform.position, -transform.forward * lenght);
                    break;
                case Space.ZY:
                    Gizmos.DrawRay(transform.position, transform.up * lenght);
                    Gizmos.DrawRay(transform.position, -transform.up * lenght);
                    break;
                default:
                    break;
            }

            Gizmos.DrawSphere(p1, .1f);
            Gizmos.DrawSphere(p2, .1f);
        }
    }
}
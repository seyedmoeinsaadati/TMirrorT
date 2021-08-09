using System;
using UnityEditor;
using UnityEngine;

namespace SMSPackages.ThreeD
{

    public class Plane : ThreeDDrawing
    {
        public enum PlaneType
        {
            XY,
            XZ,
            ZY
        }

        [SerializeField]
        protected PlaneType planeType;

        Vector3[] p;
        protected override void OnDrawGizmos()
        {
#if UNITY_EDITOR
            CalculateLinePoints();
#endif
            Gizmos.color = color;
            DrawLines();
            DrawPlane();
            Gizmos.DrawSphere(transform.position, .05f);
        }

        void CalculateLinePoints()
        {
            p = new Vector3[4];
            Vector3 pos = transform.position;
            switch (planeType)
            {
                case PlaneType.XY:
                    p[0] = new Vector3(-length, length, 0) + pos;
                    p[1] = new Vector3(length, length, 0) + pos;
                    p[2] = new Vector3(-length, -length, 0) + pos;
                    p[3] = new Vector3(length, -length, 0) + pos;
                    break;
                case PlaneType.XZ:
                    p[0] = new Vector3(-length, 0, length) + pos;
                    p[1] = new Vector3(length, 0, length) + pos;
                    p[2] = new Vector3(-length, 0, -length) + pos;
                    p[3] = new Vector3(length, 0, -length) + pos;
                    break;
                case PlaneType.ZY:
                    p[0] = new Vector3(0, -length, length) + pos;
                    p[1] = new Vector3(0, length, length) + pos;
                    p[2] = new Vector3(0, -length, -length) + pos;
                    p[3] = new Vector3(0, length, -length) + pos;
                    break;
                default:
                    break;
            }
        }

        private void DrawLines()
        {
            Gizmos.DrawLine(p[0], p[1]);
            Gizmos.DrawLine(p[0], p[2]);
            Gizmos.DrawLine(p[1], p[3]);
            Gizmos.DrawLine(p[2], p[3]);

        }

        private void DrawPlane()
        {
            Quaternion m_rotation;
            switch (planeType)
            {
                case PlaneType.XY:
                    m_rotation = Quaternion.LookRotation(Vector3.forward);
                    break;
                case PlaneType.XZ:
                    m_rotation = Quaternion.LookRotation(Vector3.up);
                    break;
                case PlaneType.ZY:
                    m_rotation = Quaternion.LookRotation(Vector3.right);
                    break;
                default:
                    m_rotation = Quaternion.identity;
                    break;
            }

            Matrix4x4 trs = Matrix4x4.TRS(transform.position, m_rotation, Vector3.one);
            Gizmos.matrix = trs;
            Color32 m_color = color;
            m_color.a = 48;
            Gizmos.color = m_color;
            Gizmos.DrawCube(Vector3.zero, new Vector3(1.0f, 1.0f, 0.0001f) * 2 * length);
            Gizmos.matrix = Matrix4x4.identity;
            Gizmos.color = color;
        }
    }
}
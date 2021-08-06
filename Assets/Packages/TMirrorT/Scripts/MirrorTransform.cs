using UnityEngine;
namespace SMSPackages.TMirrorT
{
    public class MirrorTransform : MonoBehaviour
    {
        [Tooltip("IMirror Component is prerequisites")]
        public Transform mirror;
        IMirror iMirror;
        public Transform target;

        Quaternion newRotation;
        Vector3 newPosition;

        void Start()
        {
            iMirror = mirror.GetComponent<IMirror>();
        }

        void Update()
        {

        }
        void FixedUpdate()
        {
            newPosition = iMirror.GetMirrorPosition(target.position);
            newRotation = iMirror.GetMirrorRotation(target.rotation);
            transform.position = newPosition;
            transform.rotation = newRotation;
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
        public void Show()
        {
            gameObject.SetActive(true);
        }

        void OnDisable()
        {
            Debug.Log(name + " Disabled.");
        }

        void OnDrawGizmos()
        {
            if (mirror != null)
            {
                Gizmos.color = Color.white;
                Gizmos.DrawLine(transform.position, mirror.transform.position);
            }
        }
    }
}
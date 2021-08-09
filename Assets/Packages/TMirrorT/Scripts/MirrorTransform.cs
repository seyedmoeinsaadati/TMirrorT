using UnityEngine;

namespace SMSPackages.TMirrorT
{
    public class MirrorTransform : MirrorObject
    {
        [Tooltip("IMirror Component is prerequisites")]
        public Transform mirror;
        IMirror iMirror;

        Quaternion newRotation;
        Vector3 newPosition, newScale;

        new void Start()
        {
            base.Start();
            iMirror = mirror.GetComponent<IMirror>();
            if (iMirror == null)
            {
                Debug.LogError("IMirror is null. Add IMirror component to mirror object");
            }
        }

        public override void Refresh()
        {
            if (iMirror == null)
            {
                Debug.LogError("IMirror is null. Add IMirror component to mirror object");
                return;
            }
            newPosition = iMirror.GetMirrorPosition(target.position);
            newRotation = iMirror.GetMirrorRotation(target.rotation);
            newScale = iMirror.GetMirrorScale(target.localScale);
            transform.position = newPosition;
            transform.rotation = newRotation;
            transform.localScale = newScale;
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


    }
}
using UnityEngine;
namespace SMSPackages.TMirrorT
{
    public class MirrorMaterial : MonoBehaviour
    {
        public MeshRenderer targetMeshRenderer;
        MeshRenderer meshRenderer;
        public int mat_index;
        public bool negativeMode;
        void Start()
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }

        private void FixedUpdate()
        {
            meshRenderer.materials[mat_index].color = negativeMode ? Color.white - targetMeshRenderer.material.color : targetMeshRenderer.material.color;
        }
    }
}
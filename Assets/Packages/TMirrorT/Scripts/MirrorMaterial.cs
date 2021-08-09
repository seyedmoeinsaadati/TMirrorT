using UnityEngine;
namespace SMSPackages.TMirrorT
{
    public class MirrorMaterial : MirrorObject
    {
        public MeshRenderer targetMeshRenderer;
        MeshRenderer meshRenderer;
        public int mat_index;
        public bool negativeMode;
        new void Start()
        {
            base.Start();
            targetMeshRenderer = targetMeshRenderer.GetComponent<MeshRenderer>();
            meshRenderer = GetComponent<MeshRenderer>();
        }

        public override void Refresh()
        {
            base.Refresh();
            meshRenderer.materials[mat_index].color = negativeMode ? Color.white - targetMeshRenderer.material.color : targetMeshRenderer.material.color;
        }
    }
}
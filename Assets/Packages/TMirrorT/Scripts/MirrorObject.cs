using UnityEngine;

public abstract class MirrorObject : MonoBehaviour
{
    public Transform target;
    public enum UpdateType // The available methods of updating are:
    {
        FixedUpdate, // Update in FixedUpdate (for tracking rigidbodies).
        LateUpdate, // Update in LateUpdate. (for tracking objects that are moved in Update)
        Update,
        ManualUpdate // user must call refresh method
    }

    public UpdateType updateType;

    protected void Start()
    {
        if (target == null)
        {
            Debug.LogError("IMirror is null. Add IMirror component to mirror object");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (updateType == UpdateType.Update)
        {
            Refresh();
        }
    }

    private void FixedUpdate()
    {
        if (updateType == UpdateType.FixedUpdate)
        {
            Refresh();
        }
    }

    private void LateUpdate()
    {
        if (updateType == UpdateType.LateUpdate)
        {
            Refresh();
        }
    }

    public virtual void Refresh()
    {
        Debug.Log("Mirror Object Refreshed.");
    }
}

using UnityEngine;

public class Rotate : MonoBehaviour
{

    void FixedUpdate()
    {
        Action();
    }


    void Action()
    {
        transform.Rotate(transform.forward * 90 * Time.deltaTime, Space.Self);
    }
}
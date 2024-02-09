using UnityEngine;

public class TryRayCast : MonoBehaviour
{
    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward); Vector3 fwd2 = transform.TransformDirection(Vector3.forward*10);

        if (Physics.Raycast(transform.position, fwd, 10))
            print("There is something in front of the object!");
        else { print("There is NOTHING"); }
        Debug.DrawRay(transform.position, fwd2, Color.green);
    }
}
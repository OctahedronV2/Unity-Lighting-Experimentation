using UnityEngine;

public class Spinner : MonoBehaviour
{
    public Vector3 spinRate = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinRate * Time.deltaTime);
    }
}

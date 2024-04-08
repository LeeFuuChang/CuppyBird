
using UnityEngine;

public class DestroyByPos : MonoBehaviour
{
    [SerializeField ]
    float _destroy_z=-30f;

 

    // Update is called once per frame
    void Update()
    {
        if(transform.localPosition.z<_destroy_z)
        {
            Destroy(gameObject);
        }
    }
}


using UnityEngine;

public class DestroyRebirthbyPos : MonoBehaviour
{
    [SerializeField]
    float _destory_z = -20;
    [SerializeField]
    GameObject _self_prefab;
    [SerializeField]
    Vector3 _rebirth_pos;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < _destory_z) 

        {
            Instantiate(_self_prefab, _rebirth_pos, Quaternion.identity);
            Destroy (gameObject);

        }
    }
}

using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            DetectGameOver();
        }
    }

    // Update is called once per frame
    void DetectGameOver()
    {
        Debug.Log("Game Over");
    }
}


using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField]
    int score_value = 1;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            int next_score=PlayerPrefs.GetInt("Score")+score_value;
            PlayerPrefs.SetInt("Score",next_score);
        }
           
    }

    // Update is called once per frame
    public int GetScoreValue()
    {
        return score_value;
    }
}

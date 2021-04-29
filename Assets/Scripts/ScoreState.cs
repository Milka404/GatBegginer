using UnityEngine;

public class ScoreState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EndAnim()
    {
        gameObject.GetComponent<Animator>().SetBool("UpCoin", false);
    }
}

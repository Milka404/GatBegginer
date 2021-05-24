using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        // Загрузка сохранненого счета
        // score = PlayerPrefs.GetInt("PlayerScore", 0);
        SetScore(score);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateCoins()
    {
        score += 1;
        SetScore(score);
        text.gameObject.GetComponent<Animator>().SetBool("UpCoin", true);

        // Сохранение счета
        // PlayerPrefs.SetInt("PlayerScore", score);
    }

    void SetScore(int count)
    {
        text.text =  count + "Coin " ;
    }
}

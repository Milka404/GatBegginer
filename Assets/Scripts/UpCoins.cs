using UnityEngine;

public class UpCoins : MonoBehaviour
{
    GameObject UpsAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerScore>().UpdateCoins();

            // Можно вызвать анимацию подбора монеты здесь ...

            Destroy(gameObject);
        }
    }
}

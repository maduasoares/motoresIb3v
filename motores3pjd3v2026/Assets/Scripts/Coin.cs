using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerCoins player = other.GetComponent<PlayerCoins>();

        if (player != null)
        {
            player.CollectCoin();

            Destroy(gameObject);
        }
    }
}
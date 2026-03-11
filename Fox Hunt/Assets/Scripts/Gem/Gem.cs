using UnityEngine;

public class Gem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GemCollector.Instance.AddGem();
            Debug.Log("Player picked up the Gem");
            Destroy(this.gameObject);
        }
    }
}
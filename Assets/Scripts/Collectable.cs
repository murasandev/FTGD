using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    enum ItemType { Coin, Health, Ammo, Inventory}
    [SerializeField] private ItemType itemType;

    private NewPlayer _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<NewPlayer>();

        if (itemType == ItemType.Coin)
        {
            Debug.Log("Im a coin");
        }
        else if(itemType == ItemType.Health)
        {
            Debug.Log("Im health");
        }
        else if (itemType == ItemType.Ammo)
        {
            Debug.Log("Im ammo");
        }
        else
        {
            Debug.Log("Im inventory item");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _player.coinsCollected += 1;
            _player.UpdateUI();
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour{
    GameManager gameMananger;

    // Start is called before the first frame update
    void Start()
    {
        gameMananger = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
    }

private void OnTriggerEnter(Collider otherObject){
    if(otherObject.transform.tag == "Player"){
        gameMananger.currentPickups += 1;
        Destroy(this.gameObject);
    }
}
}

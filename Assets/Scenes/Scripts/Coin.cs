using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
            void OnCollisionEnter(Collision other) {
                PlayerStarts pStats;
                if (other.collider.TryGetComponent<PlayerStarts>(out pStats)){
                    pStats.coinCount+=1;
                    Debug.Log(pStats.coinCount + " " + pStats.gameObject);
                    Destroy(gameObject); 
                }
                else{
                    Debug.Log("No");
                }
                 
                
            
        }
    //public int coinCount=0;
    // Start is called before the first frame update
   

    // Update is called once per frame
  
    //void OnCollisionEnter(Collision other){
        //Debug.Log("Hit"+other.gameObject.name);
    //}
        //void OnCollisionStay(Collision other){
        //Debug.Log("Hit"+other.gameObject.name);
       // }
        //void OnCollisionExit(Collision other){
        //Debug.Log("Left Collision"+other.gameObject.name);
       // }


      //void OnCollisionEnter(Collision other){
        //Destroy(gameObject);
       //}

}

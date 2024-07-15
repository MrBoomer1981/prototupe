using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exaple : MonoBehaviour
{

    void Start(){//вызывается при создании



    }
    // Start is called before the first frame update
  
    // Update is called once per frame
    void FixedUpdate() { //кадый физический тик
 
    
        Debug.Log(Time.fixedDeltaTime);
    
}

    void Update() { //кадый кадр
 
    
}
  void OnDestroy() {
        
      //при уничьтоджении объекта 
      Debug.Log("Destroy" + gameObject.name);
 
    
 
    }

    void OnDisable() {
    
      
        
      //при уничьтоджении объекта 
      Debug.Log("component disable" + gameObject.name);
 
    }
    void OnEnable() {
    
      
        
      //при уничьтоджении объекта 
      Debug.Log("component enable" + gameObject.name);
 
    }
    

}
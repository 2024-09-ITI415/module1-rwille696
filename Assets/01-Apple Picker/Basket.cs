using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {
    public ScoreCounter scoreCounter;

    // Start is called before the first frame update
    void Start(){
        //Find a Game Object named ScoreCounter int Hierarchy
        GameObject scoreGo = GameObject.Find("ScoreCounter");
        //Get the ScoreCounter(scrpit) component of scoreGo
        scoreCounter = scoreGo.GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update(){
        // Get current screen position of mous from Input
        Vector3 mousePos2D = Input.mousePosition;

        //Camera's Z position sets how far to push mouse into 3D
        //If this line cause a NullREfExcept, select MainCam in hierarchy and set
        // its tag to maincam in inspector
        mousePos2D.z = -Camera.main.transform.position.z;

        //Convert point from 2D screen space into 3D game
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );

        //move x position of basket to x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter( Collision coll){
        //find out what hit this basket

        GameObject collidedWith = coll.gameObject;
        if ( collidedWith.CompareTag("Apple")) {
            Destroy( collidedWith);
            //Increase the score
            scoreCounter.score += 100;
        }
    }

}

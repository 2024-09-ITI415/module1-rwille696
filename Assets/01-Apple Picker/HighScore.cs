using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //makes uGUI work
public class HighScore : MonoBehaviour {
    static private Text _UI_TEXT;
    static private int _SCORE = 1000;

    private Text txtCom;

    void Awake () {
        _UI_TEXT = this.GetComponent<Text>();

        //if the playerprefs highscore already exist, reas it
        if(PlayerPrefs.HasKey("HighScore")){
            SCORE = PlayerPrefs.GetInt("HighScore");
        }
        //Assign the high score to HighSCore
        PlayerPrefs.SetInt("HighScore", SCORE);
    }

    static public int SCORE {
        get {return _SCORE;}
        private set{
            _SCORE = value;
            PlayerPrefs.SetInt("HighScore", value);
            if(_UI_TEXT != null){
                _UI_TEXT.text = "High Score " +value.ToString("#,0");
            }
        }
    }
    static public void TRY_SET_HIGH_SCORE(int scoreToTry) {
        if (scoreToTry <= SCORE) return;
        SCORE = scoreToTry;
    }

    [Tooltip("Check this box to reset the HighScore in PlayerPrefs")]
    public bool resetHighScoreNow = false;

    void OnDrawGizmos() {
        if (resetHighScoreNow) {
            resetHighScoreNow = false;
            PlayerPrefs.SetInt("HighScore", 1000);
            Debug.LogWarning("PlayerPrefs HighScore reset to 1,000.");
        }
    }
    
}

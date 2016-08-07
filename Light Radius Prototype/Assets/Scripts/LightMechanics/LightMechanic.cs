using UnityEngine;
using System.Collections;

public class LightMechanic : MonoBehaviour {

	public Light lt;
	private float smooth;
	private float newRange;
	private Color newColor;
    bool leftClicking;
    bool rightClicking;
    float rangeA = 1.0f;
	//float rangeB = 8.0f;
    Color colorA = Color.red;//new Color(242.0f, 50.0f, 50.0f, 1f);
    Color colorB = Color.yellow;//new Color(30.0f, 40.0f, 242.0f, 1f);
    Color colorC = Color.green;//new Color(30.0f, 224.0f, 242.0f, 1f);
    Color colorD = Color.cyan;
    bool lerpBool;

    
	void Awake () {
		lt = GetComponent<Light> ();
        newRange = 2;
        lt.range = newRange;
        lt.range = 2;
		lt.intensity = 8.0f;

		//lt.color = Color.yellow;
		newColor = lt.color;

		smooth = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
        FireFlicker();
        if(lt.range < 2)
        {
            lt.range = 2;
        }
        if(lt.range > 12)
        {
            lt.range = 12;
        }
		ChangeIntensity ();
        if (newRange >= 2 && newRange < 6)
        {
            lerpBool = true;
            newColor = colorA;
        }
        if (newRange >= 6 && newRange < 8)
        {
            lerpBool = true;
            newColor = colorB;
        }
        if (newRange >= 8 && newRange <= 10 )
        {
            lerpBool = true;
            newColor = colorC;
        }
        if (newRange > 10 && newRange <= 12)
        {
            lerpBool = false;
            lt.color = colorD;
            
            //newColor = colorC;
        }
		Debug.Log ("Light range is " + lt.range);
	}

	void ChangeIntensity()
	{
        
		if (Input.GetMouseButtonDown (0)) {
            leftClicking = true;
            rightClicking = false;
			if(leftClicking == true)
            {
            gainIntensity();
            }
		}
		if (Input.GetMouseButtonDown (1)) {
            rightClicking = true;
            leftClicking = false;
			if(rightClicking == true)
            {
            loseIntensity();
            }
		}
		lt.range = Mathf.Lerp (lt.range, newRange, Time.deltaTime * smooth);
        if (lerpBool == true)
        {
            lt.color = Color.Lerp(lt.color, newColor, Time.deltaTime * smooth);
        }
	}
    void gainIntensity()
    {
        newRange += rangeA;
    }
    void loseIntensity()
    {
       newRange -= rangeA; 
    }
    float Flicker(float aValue, float aMin, float aMax)
    {
        return Mathf.PingPong(aValue, aMax - aMin) + aMin;
    }
    void FireFlicker()
    {
        lt.intensity = Flicker(Time.time, 7.5f, Random.Range(7.6f,8.0f));
		Debug.Log ("Intensity " + lt.intensity);
    }
}

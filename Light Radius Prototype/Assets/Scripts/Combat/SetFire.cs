using UnityEngine;
using System.Collections;

public class SetFire : MonoBehaviour {

	public Light lt;
    bool lrp;
	// Use this for initialization
	void Start () {
		lt = GetComponent<Light> ();
        lt.intensity = 1;
        lrp = false; 
	}
	
	// Update is called once per frame
	void Update () {
        
        if (lrp == true)
        {
            lt.intensity = Mathf.Lerp(lt.intensity, 8.0f, Time.deltaTime);
        }
        if(lt.intensity > 7)
        {
            lrp = false;
            FireFlicker();
        }
	}

	void OnTriggerEnter(Collider other)
	{
        lrp = true;
        lt.enabled = true;
        
		this.transform.Rotate (-90, 0, 0);
	}
    float Flicker(float aValue, float aMin, float aMax)
    {
        return Mathf.PingPong(aValue, aMax - aMin) + aMin;
    }
    void FireFlicker()
    {
        lt.intensity = Flicker(Time.time, 7.5f, Random.Range(7.8f, 8.0f));
    }
}

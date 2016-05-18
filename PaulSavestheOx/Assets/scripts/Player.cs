using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public int health;

	public int maxhealth;

	public int stamina;

	public int maxstamina;

	public int logtotal;

	public Image healthbar;

	public Image staminabar;

	public Image log1,log2,log3;

	void logui(){
		if (logtotal == 1)
			log1.enabled = true;

		if (logtotal == 2)
			log2.enabled = true;

		if (logtotal == 3)
			log3.enabled = true;
	}


	// Use this for initialization
	void Start () {
		//sets starting values for health and stamina to be used with ui;
		health = 100;
		maxhealth = 100;
		stamina = 100;
		maxstamina = 100;

		//setting the pickup images in the ui for the logs to false
		log1.enabled = false;
		log2.enabled = false;
		log3.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.CompareTag ("health")) {
			health -= 10;
			if (health < 0)
				health = 0;
			healthbar.fillAmount = health * .01f;
			Destroy(other.gameObject);
		}
		if (other.gameObject.CompareTag ("stamina")) {
			stamina -= 10;
			if (stamina < 0)
				stamina = 0;
			staminabar.fillAmount = stamina * .01f;
			Destroy(other.gameObject);
		}

		if (other.gameObject.CompareTag ("log")) {
			logtotal += 1;
			logui();
			Destroy(other.gameObject);
		}
	}
}

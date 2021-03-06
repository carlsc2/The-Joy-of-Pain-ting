using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[RequireComponent(typeof(AudioSource))]

public class TitleAudioLines : MonoBehaviour {
	public AudioSource source;
	public List<AudioClip> lines;
	public float wait = 5f;

	void Start () {
		StartCoroutine (playLines());
	}

	IEnumerator playLines () {
		while (true) {
			yield return new WaitForSeconds (wait);
			if (lines.Count > 0) {
				int line = (int)Mathf.Floor (Random.Range (0.0f, (float)lines.Count - 0.01f));
				GetComponent<AudioSource> ().clip = lines[line];
				GetComponent<AudioSource> ().Play ();
			}
		}
	}
}


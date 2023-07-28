using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class musicmanager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] songs;
    public float volume;
    public Text currentSong;
    [SerializeField] private float tracktimer;
    [SerializeField] private float songeplayed;
    [SerializeField] private bool[] beenplayed;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
        beenplayed=new bool[songs.Length];
        if (!audioSource.isPlaying)
        {
            ChangeSong(Random.Range(0,songs.Length));
        }
    }

    
    void Update()
    {
        currentSong.text = audioSource.clip.name;
        
        audioSource.volume=volume;
        if (audioSource.isPlaying)
        {
            tracktimer+=1*Time.deltaTime;
            
        }
        if (!audioSource.isPlaying || tracktimer>= audioSource.clip.length || Input.GetKeyDown(KeyCode.Space))
        {
            ChangeSong(Random.Range(0,songs.Length));
        }

        if (songeplayed==songs.Length)
        {
            songeplayed=0;
            for(int i=0;i<songs.Length;i++)
            {
                if (i==songs.Length)
                    break;
                else
                    beenplayed[i]=false;
            }
        }
    }

    public void ChangeSong(int songpicked)
    {
        if (!beenplayed[songpicked])
        {
            tracktimer=0;
            songeplayed++;
            beenplayed[songpicked]=true;
            audioSource.clip=songs[songpicked];
            audioSource.Play();
            
        }
        else
        {
            audioSource.Stop();
        }
        
    }
}

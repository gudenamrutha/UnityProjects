using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnZone : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject spawnZone;
    [SerializeField]
    private float _time = 7.0f;
    [SerializeField]
    private GameObject spawnTarget;
    private float minLimitx;
    private float maxLimitx;
    private float minLimitz;
    private float maxLimitz;
    private float curtime = 0.0f;
    void Start()
    {
        minLimitx = spawnZone.GetComponent<BoxCollider>().bounds.min.x;
        maxLimitx = spawnZone.GetComponent <BoxCollider>().bounds.max.x;  
        maxLimitz = spawnZone.GetComponent<BoxCollider>().bounds .max.z;    
        minLimitz = spawnZone.GetComponent<BoxCollider>() .bounds .min.z;
    }

    // Update is called once per frame
    void Update()
    {
        
        curtime += Time.deltaTime;
        if (curtime > _time)
        {
           
            if(GameObject.FindWithTag("target") != null)
            {
                
                Destroy(GameObject.FindWithTag("target"));
              
                SoundTracker st = GetComponent<SoundTracker>();
                st.soundFX[0].Play();
            }
            curtime = 0f;
            Vector3 position = new Vector3(Random.Range(minLimitx,maxLimitx), 5f, Random.Range(minLimitz,maxLimitz));
            Instantiate(spawnTarget, position, Quaternion.identity);
        }
    }
}

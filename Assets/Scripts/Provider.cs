using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Provider : MonoBehaviour
{
    [SerializeField] float mintime, maxtime;
    [SerializeField] int stars;
    [SerializeField] GameObject particle;
    [SerializeField] Vector3 particleOffset;
    bool looping = true;

    StarDisplay starDisplay;

    void Start()
    {
        starDisplay = FindObjectOfType<StarDisplay>();
        StartCoroutine(AddStars());
    }

    private IEnumerator AddStars()
    {
        do
        {
            yield return new WaitForSeconds(Random.Range(mintime, maxtime));
            starDisplay.AddStars(stars);
            PlayVFX();
        }
        while (looping);
    }

    private void PlayVFX()
    {
        if (!particle) { return; }
        GameObject vfx = Instantiate(particle, transform.position + particleOffset, Quaternion.identity);
        var duration = vfx.GetComponent<ParticleSystem>().main.startLifetime.constantMax;
        Destroy(vfx, duration);
    }

}

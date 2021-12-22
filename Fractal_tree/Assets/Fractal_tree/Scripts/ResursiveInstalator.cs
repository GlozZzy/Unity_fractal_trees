using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResursiveInstalator : MonoBehaviour
{
    public int recurse;
    private int split = 2;

    public int greenRange;
    public Material greenMaterial;

    // Start is called before the first frame update
    void Start()
    {
        recurse -= 1;
        for (int i = 0; i < split; i++)
        {
            if (recurse < greenRange)
            {
                gameObject.transform.GetChild(0).GetComponent<Renderer>().material = greenMaterial;
            }
            if (recurse > 0)
            {
                
                var copy = Instantiate(gameObject);
                copy.transform.SetParent(transform.parent);
                var recursive = copy.GetComponent<ResursiveInstalator>();
                recursive.SendMessage("Generated", i);
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x * 3, transform.localScale.y, transform.localScale.z);
            }
        }
    }
}

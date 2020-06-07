using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutUpdateDisabler : MonoBehaviour
{
    public MultipleMonitorLayouter multipleMonitorLayouter;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisabledUpdateFrame());
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    private IEnumerator DisabledUpdateFrame()
    {
        yield return new WaitForSeconds(1f);
        multipleMonitorLayouter.updateEveryFrame = false;
        yield return null;
    }
}

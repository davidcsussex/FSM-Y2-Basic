using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;




[DefaultExecutionOrder(-1)]



public class UIscript : MonoBehaviour
{

    public static UIscript ui;

    // this script must have a high priority in project settings

    StringBuilder sb;
    // Start is called before the first frame update

    private void Awake()
    {
        if (ui == null)
        {
            ui = this;
        }
        else
        {
            if (ui != this)
            {
                Destroy(gameObject);
            }
        }
    }


    void Start()
    {
        sb = new StringBuilder();
    }

    // Update is called once per frame
    void Update()
    {
        ClearGui();
    }


    private void OnGUI()
    {
        string text = sb.ToString();
        GUILayout.BeginArea(new Rect(10f, 10f, 800f, 800f));
        GUILayout.Label($"<color='white'><size=20>{text}</size></color>");
        GUILayout.EndArea();
    }

    public void ClearGui()
    {
        sb.Clear();
    }

    public void DrawText(string text)
    {
        sb.AppendLine(text);
    }
}

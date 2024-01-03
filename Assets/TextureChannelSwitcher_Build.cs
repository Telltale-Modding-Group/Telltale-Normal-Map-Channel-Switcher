using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
//using UnityEditor;
//using UnityEditor.SceneManagement;
using System.Linq;



public class TextureChannelSwitcher_Build : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        
        
        
        
        Texture2D tex = null;
        byte[] fileData;
        Debug.Log("script loaded");
        
        
        string[] aFilePaths = Directory.GetFiles("textures");

		foreach (string sFilePath in aFilePaths)
		{
			if (Path.GetExtension(sFilePath) == ".png")
			{
				
        
                
                    fileData = File.ReadAllBytes(sFilePath);
                    tex = new Texture2D(2, 2);
                    tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
                    Debug.Log("texture loaded");
                    Color[] pixels = tex.GetPixels(0);
                    //Color originalColor = tex.GetPixel(x, y)
                    int pixelsCount = pixels.Length;
                    Debug.Log(pixelsCount);
                    //foreach (Color element in pixels)
                    for (int i=0; i<pixelsCount; i++)
                    {
                        
                        pixels[i] = new Color(pixels[i].a, pixels[i].b, pixels[i].g, pixels[i].r);
                        
                        
                    }
                    tex.SetPixels(pixels, 0);
                    Debug.Log("script finished");
                    byte[] bytes = tex.EncodeToPNG();
                    File.WriteAllBytes(sFilePath, bytes);
                    Debug.Log("image updated");
                    
                    
                
        
            }
            
		}
        
        
        

    }


}

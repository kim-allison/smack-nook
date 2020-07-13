/*

   .-------.                             .--.    .-------.     .--.            .--.     .--.        
   |       |--.--.--------.-----.-----.--|  |    |_     _|--.--|  |_.-----.----|__|---.-|  |-----.
   |   -   |_   _|        |  _  |     |  _  |      |   | |  |  |   _|  _  |   _|  |  _  |  |__ --|
   |_______|__.__|__|__|__|_____|__|__|_____|      |___| |_____|____|_____|__| |__|___._|__|_____|
   © 2019 OXMOND / www.oxmond.com 

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCursor : MonoBehaviour
{
    public Texture2D cursorArrow;

    void Start()
    {
        // Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
}


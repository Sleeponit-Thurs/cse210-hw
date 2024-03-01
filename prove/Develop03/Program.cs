using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu menu = new();
            menu.DisplayMenu();
            Reference scriptureGame = new();
            scriptureGame.GetVerse();
            scriptureGame.PlayScriptureGame();
        }
        
    }
}
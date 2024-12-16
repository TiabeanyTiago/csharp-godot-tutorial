using Godot;
using System;
using System.Collections.Generic;

public enum eSceneNames
{
    Main = 10,
    MainMenu = 20,
    Level2 = 30
}

public partial class SceneManager : Node
{

    public static SceneManager instance;

    public Dictionary<eSceneNames, SceneData> sceneDictionary = new Dictionary<eSceneNames, SceneData>() {
        {eSceneNames.Main, new SceneData("res://scenes/10_Main.tscn", "Main", false) },
        {eSceneNames.MainMenu, new SceneData("res://scenes/20_MainMenu.tscn", "Main Menu", false) },
        {eSceneNames.Level2, new SceneData("res://scenes/30_Level2.tscn", "Level Two", true) },
    };

    public override void _Ready()
    {
        instance = this;
    }

    public void ChangeScene(eSceneNames mySceneName)
    {
        string myPath = sceneDictionary[mySceneName].Path;
        GameMaster.pauseAllowed = sceneDictionary[mySceneName].PauseAllowed;
        GetTree().ChangeSceneToFile(myPath);
    }

}
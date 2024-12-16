public class SceneData
{
    public string Path { get; init; }
    public string PrettyName { get; init; }
    public bool PauseAllowed { get; init; }

    public SceneData(string path, string prettyName, bool pauseAllowed)
    {
        Path = path;
        PrettyName = prettyName;
        PauseAllowed = pauseAllowed;
    }
}
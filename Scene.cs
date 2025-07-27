namespace ConsoleGameEngine
{
    public class Scene
    {
        public string id;
        public string description;
        public string[] actions;

        public override string ToString()
        {
            return $"Scene {id} description {description}";
        }
    }
}
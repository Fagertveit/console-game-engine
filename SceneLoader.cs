using System.Text.Json;
using Newtonsoft.Json;

namespace ConsoleGameEngine
{
    static class SceneLoader
    {
        static public Scene LoadScene(string file)
        {
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                Scene scene = JsonConvert.DeserializeObject<Scene>(json);

                return scene;
            }
        }
    }
}

/*
public void LoadJson()
    {
        using (StreamReader r = new StreamReader("file.json"))
        {
            string json = r.ReadToEnd();
            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
        }
    }
*/
using pcs.Modding;

namespace ModPCS
{
    public class Mod : PCSMod
    {
        public string Name()
        {
            return "My PCS Mod"; //This is mod name.
        }

        public string Author()
        {
            return "?"; //This is mod author's name.
        }

        public string ModID()
        {
            return "pcsmod"; //This is mod ID.
        }

        public string Version()
        {
            return "1.0.0.0"; //This is mod version
        }

        public void Init()
        {
            
        }

        public void PreInit()
        {
            
        }

        public void PostInit()
        {
            
        }
    }
}

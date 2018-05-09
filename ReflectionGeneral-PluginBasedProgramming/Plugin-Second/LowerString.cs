using SDK;


namespace Plugin_Second
{
    public class LowerString : IPlugin
    {
        public string action(string text)
        {
            return text.ToLower();
        }

        public string name()
        {
            return "Küçük Harf";
        }
    }
}

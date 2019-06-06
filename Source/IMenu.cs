namespace Source
{
    public interface IMenu
    {
        void PushMenu(IMenu menu);
        IMenu PopMenu();

        void Display();
        void HandleInput();
    }
}

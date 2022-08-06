using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLib
{
    public class Menu<T>
    {
        private static List<MenuItem<T>> menuItems;
        private MenuProperties properties;
        private MenuItem<T> title;
        private int seletedItemIndex;
        private ConsoleColor baseBackColor;
        private ConsoleColor baseForeColor;
        public Menu(string title)
        {
            menuItems = new List<MenuItem<T>>();
            properties = new MenuProperties();
            this.title = new MenuItem<T>(properties, title);
            seletedItemIndex = 0;
            baseBackColor = Console.BackgroundColor;
            baseForeColor = Console.ForegroundColor;
        }
        public void AddItem(T number, string text)
        {
            menuItems.Add(new MenuItem<T>(number, properties, text));
        }
        public T Choice()
        {
            Console.Clear();
            Controls controls = new Controls();
            Show(seletedItemIndex);

            do
            {
                var button = Console.ReadKey().Key;
                switch (button)
                {
                    case ConsoleKey.DownArrow:
                        seletedItemIndex++;
                        seletedItemIndex = (seletedItemIndex + menuItems.Count) % menuItems.Count;
                        Show(seletedItemIndex);
                        break;

                    case ConsoleKey.UpArrow:
                        seletedItemIndex--;
                        seletedItemIndex = (seletedItemIndex + menuItems.Count) % menuItems.Count;
                        Show(seletedItemIndex);
                        break;

                    case ConsoleKey.Enter:
                        return menuItems[seletedItemIndex].Id;

                    default:
                        break;
                }
            } while (true);
        }
        private void Show(int pointer)
        {
            Controls control = new Controls();
            control.CursorPositionTop = pointer;
            Console.SetCursorPosition(0, 0);
            title.Print();
            for (int i = 0; i < menuItems.Count; i++)
            {
                menuItems[i].PrintWithChoice(i, control);
            }
            Console.BackgroundColor = baseBackColor;
            Console.ForegroundColor = baseForeColor;
        }
    }
}

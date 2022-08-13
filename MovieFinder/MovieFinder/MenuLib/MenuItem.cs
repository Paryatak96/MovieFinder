using ClassesWithObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLib
{
    class MenuItem<T>
    {
        private MenuProperties properties;
        private ItemProperties itemProperties = new ItemProperties();
        private string text;
        private MovieModel model;
        private T id;
        private bool isTitle;
        public MenuItem(MenuProperties properties, string text)
        {
            this.properties = properties;
            this.text = text;
            this.isTitle = true;

            if (properties.TextSize < text.Length)
            {
                properties.TextSize = text.Length;
            }
        }
        public MenuItem(T id, MenuProperties properties, string text)
        {
            this.id = id;
            this.properties = properties;
            this.text = text;
            this.isTitle = false;

            if (properties.TextSize < text.Length)
            {
                properties.TextSize = text.Length;
            }
        }
        public MenuItem(T id, MenuProperties properties, MovieModel text)
        {
            this.id = id;
            this.properties = properties;
            this.model = text;
            this.isTitle = false;

            if (properties.TextSize < model.Title.Length)
            {
                properties.TextSize = model.Title.Length;
            }
        }
        public void Print()
        {
            if (isTitle)
            {
                Print(properties.Title);
            }
        }
        public void PrintWithChoice(int index, Controls control)
        {
            if (control.CursorPositionTop == index)
            {
                Print(properties.SelectedItem);
            }
            else
            {
                Print(properties.Item);
            }
        }
        private void Print(ItemProperties itemProperties)
        {
            Controls controls = new Controls();
            string pefix = itemProperties.Prefix;
            string postfix = itemProperties.Postfix;
            Console.BackgroundColor = itemProperties.BackgroundColor;
            Console.ForegroundColor = itemProperties.TextColor;
            string idText = id.ToString() + " - ";

            int textSize = properties.TextSize;
            if (isTitle)
            {
                textSize += idText.Length;
                idText = "";
                Console.WriteLine("{0}{1}{2,-" + textSize + "}{3}", pefix, idText, text, postfix);  
            }
            else
            {
                Console.WriteLine("{0}{1}{2,-" + textSize + "}{3}", pefix, idText, text, postfix);
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public T Id => id;
    }
}

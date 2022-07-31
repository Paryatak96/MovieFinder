using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLib
{
    class MenuProperties
    {
        public ItemProperties Title { get; }
        public ItemProperties Item { get; }
        public ItemProperties SelectedItem { get; }
        public int TextSize { get; set; }
        
        
        public MenuProperties()
        {
            Title = new ItemProperties();
            Title.Prefix = "~~ ";
            Title.Postfix = " ~~";
            Title.BackgroundColor = ConsoleColor.DarkGray;
            Title.TextColor = ConsoleColor.Black;


            Item = new ItemProperties();
            Item.Prefix = ">> ";
            Item.Postfix = " <<";
            Item.BackgroundColor = ConsoleColor.Gray;
            Item.TextColor = ConsoleColor.Black;

            SelectedItem = new ItemProperties();
            SelectedItem.Prefix = "** ";
            SelectedItem.Postfix = " **";
            SelectedItem.BackgroundColor = ConsoleColor.Yellow;
            SelectedItem.TextColor = ConsoleColor.Black;

        }

       
    }
}

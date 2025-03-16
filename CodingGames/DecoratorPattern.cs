using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class Design_pattern
    {
        interface Window
        {
            void Draw();
        }
        class SimpleWindow : Window
        {
            public void Draw()
            {
            }
        }
        abstract class WindowEnhacement : Window
        {
            protected Window _window;
            public WindowEnhacement(Window window)
            {
                this._window = window;
            }
            abstract public void Draw();

        }
        class ScrollBarEnhacement : WindowEnhacement
        {
            public ScrollBarEnhacement(Window window) : base(window)
            {
            }
            public override void Draw()
            {
                DrawScrollBars();
                //window.Draw();
            }
            private void DrawScrollBars()
            {

            }
        }
        //class WindowTest
        //{
        //    public static void Main()
        //    {
        //        Window w = new ScrollBarEnhacement(new SimpleWindow());
        //        w.Draw();   
        //    }
        //}
    }
}

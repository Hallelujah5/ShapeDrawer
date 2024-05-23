using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = SplashKitSDK.Color;
using System.Runtime.InteropServices;


namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {


            Shape myShape = new Shape();
            Window window = new Window("Shape Drawer", 800, 600);

            Drawing myDrawing = new Drawing();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {

                    Shape shape = new Shape();
                    shape.X = (float)SplashKit.MouseX();
                    shape.Y = (float)SplashKit.MouseY();
                    myDrawing.AddShape(shape);
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {   
                        myDrawing.Background = Color.RandomRGB(255);   
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton)) 
                {
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());

                }

                
                    if (SplashKit.KeyTyped(KeyCode.DeleteKey) || (SplashKit.KeyTyped(KeyCode.BackspaceKey)))
                    {
                        myDrawing.RemoveShape();
                    } 
                
                

                myDrawing.Draw();
                SplashKit.RefreshScreen();

            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));





            //Shape myShape = new Shape();
            //Window window = new Window("Shape Drawer", 800, 600);
            //do
            //{
            //    SplashKit.ProcessEvents();
            //    SplashKit.ClearScreen();

            //    if (SplashKit.MouseClicked(MouseButton.LeftButton))
            //    {   
            //        myShape.X = (float)SplashKit.MouseX();
            //        myShape.Y = (float)SplashKit.MouseY();
            //    }
            //    if (SplashKit.KeyTyped(KeyCode.SpaceKey))
            //    {
            //        if (myShape.IsAt(SplashKit.MousePosition()))
            //        {
            //            myShape.Color = Color.RandomRGB(255);
            //        }
            //    }
            //    myShape.Draw();
            //    SplashKit.RefreshScreen();


            //}
            //while (!SplashKit.WindowCloseRequested("Shape Drawer"));





            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}


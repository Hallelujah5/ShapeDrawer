using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using Color = SplashKitSDK.Color;
using System.Runtime.InteropServices;

    



namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;




        public Color Background { get { return _background; } set { _background = value; } }
        public Drawing() : this(Color.White)
        {

        }

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }
        public int ShapeCount { get { return _shapes.Count; } }


        //methods

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape s in _shapes) { 
                if (s.Selected)
                    {
                        result.Add(s);
                    }
                        
                }
                return result;
            }
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes) 
            { if (s.IsAt(pt))
                {
                    s.Selected = true; 
                }
            else { s.Selected = false; }
            }
        }
        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape shape in _shapes) 
            {
                shape.Draw();            
            }
        }

        public void AddShape (Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape()
        {
            foreach (Shape s in _shapes.ToList())
            {
                if (s.Selected)
                {
                    _shapes.Remove(s);
                }

            }
        }












}
}

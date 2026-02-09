using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class OOPDraw : Form
    {
        public OOPDraw()
        {
            InitializeComponent();
            DoubleBuffered = true; //Stops image flickering
            LineWidth.SelectedItem = "Medium";
            ColourOption.SelectedItem = "Green";
            BrushOption.SelectedItem = "Line";
            ActionOption.SelectedItem = "Draw";
        }

        Pen currentPen = new Pen(Color.Black);
        bool dragging = false;
        Point startOfDrag = Point.Empty;
        Point lastMousePosition = Point.Empty;
        List<Shape> shapes = new List<Shape>();
        Rectangle selectionBox;

        private void SelectShapes()
        {
            DeselectAll();
            foreach (Shape s in shapes)
            {
                if (selectionBox.FullySurrounds(s)) s.Select();
            }
        }

        private List<Shape> GetSelectedShapes()
        {
            return shapes.Where(s => s.Selected).ToList();
        }

        private void MoveSelectedShapes(MouseEventArgs e)
        {
            foreach (Shape s in GetSelectedShapes())
            {
                s.MoveBy(e.X - lastMousePosition.X, e.Y - lastMousePosition.Y);
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach (Shape shape in shapes) shape.Draw(gr);

            if (selectionBox != null) selectionBox.Draw(gr);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startOfDrag = lastMousePosition = e.Location;
            switch (ActionOption.Text)
            {
                case "Draw":
                    AddShape(e);
                    break;
                case "Select":
                    Pen p = new Pen(Color.Black, 1.0F);
                    selectionBox = new Rectangle(p, startOfDrag.X, startOfDrag.Y);
                    break;
            }
        }

        private void AddShape(MouseEventArgs e)
        {
            switch (BrushOption.Text)
            {
                case "Line":
                    shapes.Add(new Line(currentPen, e.X, e.Y));
                    break;
                case "Rectangle":
                    shapes.Add(new Rectangle(currentPen, e.X, e.Y));
                    break;
                case "Ellipse":
                    shapes.Add(new Ellipse(currentPen, e.X, e.Y));
                    break;
                case "Circle":
                    shapes.Add(new Circle(currentPen, e.X, e.Y));
                    break;
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            lastMousePosition = Point.Empty;
            selectionBox = null;
            Refresh();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Shape currentShape = shapes.Last();
                switch (ActionOption.Text)
                {
                    case "Move":
                        MoveSelectedShapes(e);
                        break;
                    case "Draw":
                        currentShape.GrowTo(e.X, e.Y);
                        break;
                    case "Select":
                        selectionBox.GrowTo(e.X, e.Y);
                        SelectShapes();
                        break;
                }
                lastMousePosition = e.Location;
                Refresh();
            }
        }

        private void LineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            float width = currentPen.Width;

            switch (LineWidth.Text)
            {
                case "Thin":
                    width = 2.0F;
                    break;
                case "Medium":
                    width = 4.0F;
                    break;
                case "Thick":
                    width = 8.0F;
                    break;
            }

            currentPen = new Pen(currentPen.Color, width);
        }

        private void ColourOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = currentPen.Color;
            switch (ColourOption.Text)
            {
                case "Red":
                    color = Color.Red;
                    break;
                case "Blue":
                    color = Color.Blue;
                    break;
                case "Green":
                    color = Color.Green;
                    break;
            }

            currentPen = new Pen(color, currentPen.Width);
        }

        private void DeselectAll()
        {
            foreach (Shape shape in shapes)
            {
                shape.Deselect();
            }
        }

        private void OOPDraw_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿namespace _02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {
            IShape rectangle = new Rectangle();
            GraphicEditor graphicEditor = new GraphicEditor();

            graphicEditor.DrawShape(rectangle);
        }
    }
}
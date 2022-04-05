using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPOPractProject
{
    public class SizeImage
    {
       public int Width { get; set; }
       public int Height { get; set; }

       public SizeImage(int w, int h)
       {
            Width = w;
            Height = h;
       } 
    }

    class Diagram
    {
        SizeImage size;
        Bitmap frameImage;
        Graphics frameGraph;

        string textX;
        string textY;

        Font font = new Font("Times New Roman", 15, FontStyle.Regular);

        Pen graphPen = new Pen(Color.Black);
        Pen diagramPointsPen = new Pen(Color.Blue);
        Pen diagramPen;       

        PointF firstPointX;
        PointF firstPointY;

        int stepX;
        int stepY;        

        List<PointF> pointsGraph = new List<PointF>();

        int countPointsX;
        int countPointsY;

        public Diagram(SizeImage sizeImage, int countX, int countY, Color diagrammColor, int stepByX, int stepByY, string textToX, string textToY)
        {
            size = sizeImage;
            frameImage = new Bitmap(size.Width, size.Height);
            firstPointX = new PointF(0f, (float)size.Height / 2);
            firstPointY = new PointF(0.0F, 0.0F);
            diagramPen = new Pen(diagrammColor);
            countPointsX = countX;
            countPointsY = countY;
            stepX = stepByX;
            stepY = stepByY;
            textX = textToX;
            textY = textToY;

            frameGraph = Graphics.FromImage(frameImage);            
        }

        public Bitmap DrawDiagram()
        {            
            DrawPointsX(countPointsX);
            DrawPointsY(countPointsY);
            DrawGraphPoints(ParametrsBox.temperatures);
            DrawGraph();
            return frameImage;
        }

        void DrawPointsX(int countPoints)
        {
            float x = 0f;
            PointF lastPoint = new PointF();
            for (int i = 0; i < countPoints; i++)
            {
                x += stepX;
                lastPoint = new PointF(x, (float)size.Height / 2f + 4f);
                frameGraph.DrawLine(graphPen, new PointF(x, (float)size.Height / 2f - 4f), lastPoint);                
            }
            frameGraph.DrawString(textX, font, Brushes.Black, lastPoint);
            frameGraph.DrawLine(graphPen, firstPointX, new PointF(x, (float)size.Height / 2f));
        }

        void DrawPointsY(int countY)
        {
            float y = 0f;            
            frameGraph.DrawString(textY, font, Brushes.Black, new PointF(8f, y));
            for (int i = 0; i < countY; i++)
            {
                y += stepY;                
                frameGraph.DrawLine(graphPen, new PointF(-5f, y), new PointF(5f, y));
            }
            frameGraph.DrawLine(graphPen, firstPointY, new PointF(0f, y));
        }

        void DrawGraphPoints(List<int> data)
        {
            float x = 0;
            if(data == null)
            {
                throw new Exception("Отсутствуют данные!");
            }
            else
            {
                foreach (int value in data)
                {                    
                    x += stepX;                   
                    pointsGraph.Add(new PointF(x, (float)size.Height / 2f - (stepY * value)));
                    frameGraph.DrawEllipse(diagramPointsPen, x, (float)size.Height / 2f - (stepY * value), 1f, 1f);
                }
            }            
        }

        void DrawGraph()
        {
            for(int i = 1; i < pointsGraph.Count; i++)
            {
                frameGraph.DrawLine(diagramPen, pointsGraph[i - 1], pointsGraph[i]);
            }
        }
    }    
}

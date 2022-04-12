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

    enum Indent
    {
        ONES,
        TENS,
        HUNDREDS
    };

    class Diagram
    {
        SizeImage size;
        Indent indend;
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
        int stepDiagramY;

        List<PointF> pointsGraph = new List<PointF>();

        int countPointsX;
        int countPointsY;

        bool unsignedDiagram;

        List<int> drawPoints;

        public Diagram(int countX, int countY, Indent indends, Color diagrammColor, int stepByX, int stepByY, string textToX, string textToY, List<int> points, bool unsigned)
        {            
            diagramPen = new Pen(diagrammColor);
            countPointsX = countX;
            countPointsY = countY;
            indend = indends;
            stepX = stepByX;
            stepY = stepByY;
            textX = textToX;
            textY = textToY;
            drawPoints = points;
            unsignedDiagram = unsigned;                      
        }

        public Bitmap DrawDiagram()
        {
            CalculateSize();
            DrawPointsX(countPointsX);
            DrawPointsY(countPointsY, unsignedDiagram);
            DrawGraphPoints(drawPoints);
            DrawGraph();
            return frameImage;
        }

        void CalculateSize()
        {
            size = new SizeImage(stepX * countPointsX + 100, stepY * (countPointsY * 2));
            frameImage = new Bitmap(size.Width, size.Height);
            firstPointX = new PointF(0f, (float)size.Height / 2);
            firstPointY = new PointF(0.0F, 0.0F);

            frameGraph = Graphics.FromImage(frameImage);

            switch (indend)
            {
                case Indent.ONES:
                    stepDiagramY = stepY;
                    break;
                case Indent.TENS:
                    stepDiagramY = stepY / 10;
                    break;
                case Indent.HUNDREDS:
                    stepDiagramY = stepY / 100;
                    break;                
            }
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

        void DrawPointsY(int countY, bool unsignedLine)
        {
            float unsignedY = 0f;
            float signedY = size.Height / 2;
            frameGraph.DrawString(textY, font, Brushes.Black, new PointF(8f, unsignedY));
            for (int i = 0; i < size.Height / 2; i++)
            {
                unsignedY += stepY;                
                frameGraph.DrawLine(graphPen, new PointF(-5f, unsignedY), new PointF(5f, unsignedY));
                if (!unsignedLine)
                {
                    signedY += stepY;
                    frameGraph.DrawLine(graphPen, new PointF(-5f, signedY), new PointF(5f, signedY));
                }
            }
            frameGraph.DrawLine(graphPen, firstPointY, new PointF(0f, signedY));
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
                    pointsGraph.Add(new PointF(x, (float)size.Height / 2f - (stepDiagramY * value)));
                    frameGraph.DrawEllipse(diagramPointsPen, x, (float)size.Height / 2f - (stepDiagramY * value), 1f, 1f);
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

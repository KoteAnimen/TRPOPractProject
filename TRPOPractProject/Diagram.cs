using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPOPractProject
{    
    class Diagram
    {
        static int widthImage = 1400;
        static int heightImage = 500; 

        Bitmap frameImage = new Bitmap(widthImage, heightImage);

        Pen graphPen = new Pen(Color.Black);
        Pen diagramPointsPen = new Pen(Color.Blue);
        Pen diagramPen = new Pen(Color.Red);

        Font font = new Font("Times New Roman", 15, FontStyle.Regular);        

        Graphics frameGraph;

        PointF firstPointX = new PointF(0f, (float)heightImage / 2);
        PointF firstPointY = new PointF(0.0F, 0.0F);

        float stepX = 20f;
        float stepY = 10f;        

        List<PointF> pointsGraph = new List<PointF>();

        int countPointsX = 0;
        int countPointsY = 0;

        public Diagram(int countX, int countY)
        {
            frameGraph = Graphics.FromImage(frameImage);
            countPointsX = countX;
            countPointsY = countY;
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
                lastPoint = new PointF(x, (float)heightImage / 2f + 4f);
                frameGraph.DrawLine(graphPen, new PointF(x, (float)heightImage / 2f - 4f), lastPoint);                
            }
            frameGraph.DrawString("Дни месяца", font, Brushes.Black, lastPoint);
            frameGraph.DrawLine(graphPen, firstPointX, new PointF(x, (float)heightImage / 2f));
        }

        void DrawPointsY(int countY)
        {
            float y = 0f;            
            frameGraph.DrawString("t", font, Brushes.Black, new PointF(8f, y));
            for (int i = 0; i < countY; i++)
            {
                y += stepY;                
                frameGraph.DrawLine(graphPen, new PointF(-5f, y), new PointF(5f, y));
            }
            frameGraph.DrawLine(graphPen, firstPointY, new PointF(0f, y));
        }

        void DrawGraphPoints(List<int> temperatures)
        {
            float x = 0;
            if(temperatures == null)
            {
                throw new Exception("Отсутствуют значения температур!");
            }
            else
            {
                foreach (int temperature in temperatures)
                {                    
                    x += stepX;                   
                    pointsGraph.Add(new PointF(x, (float)heightImage / 2f - (stepY * temperature)));
                    frameGraph.DrawEllipse(diagramPointsPen, x, (float)heightImage / 2f - (stepY * temperature), 1f, 1f);
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

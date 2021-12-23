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
        Bitmap frameImage = new Bitmap(3000, 2400);

        Pen graphPen = new Pen(Color.Black);
        Pen diagramPointsPen = new Pen(Color.Blue);
        Pen diagramPen = new Pen(Color.Red);

        Font font = new Font("Times New Roman", 15, FontStyle.Regular);        

        Graphics frameGraph; 
        
        PointF point1 = new PointF(0.0F, 300.0F);
        PointF point2 = new PointF(650.0F, 300.0F);

        PointF point3 = new PointF(0.0F, 550.0F);
        PointF point4 = new PointF(0.0F, 50.0F);

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
            frameGraph.DrawLine(graphPen, point1, point2);
            frameGraph.DrawLine(graphPen, point3, point4);
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
                x += 20;
                PointF p1 = new PointF(x, 295f);
                PointF p2 = new PointF(x, 305f);
                frameGraph.DrawLine(graphPen, p1, p2);
                lastPoint = p2;
            }
            frameGraph.DrawString("Дни месяца", font, Brushes.Black, lastPoint);
        }

        void DrawPointsY(int countY)
        {
            float y = 40f;
            PointF firstPoint = new PointF(8f, y);
            frameGraph.DrawString("t", font, Brushes.Black, firstPoint);
            for (int i = 0; i < countY; i++)
            {
                y += 10;
                PointF p1 = new PointF(-5f, y);
                PointF p2 = new PointF(5f, y);
                frameGraph.DrawLine(graphPen, p1, p2);
            }
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
                    float y = 300f;
                    x += 20f;
                    PointF point = new PointF(x, y - (10 * temperature));
                    pointsGraph.Add(point);
                    frameGraph.DrawEllipse(diagramPointsPen, x, y - (10 * temperature), 1f, 1f);
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

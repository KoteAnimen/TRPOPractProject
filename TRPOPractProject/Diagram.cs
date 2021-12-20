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
        Bitmap frameImage = new Bitmap(1000, 800);
        Pen graphPen = new Pen(Color.Black);
        Graphics frameGraph;        
        PointF point1 = new PointF(0.0F, 300.0F);
        PointF point2 = new PointF(1000.0F, 300.0F);

        PointF point3 = new PointF(0.0F, 520.0F);
        PointF point4 = new PointF(0.0F, 30.0F);

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
            return frameImage;
        }

        public void DrawPointsX(int countPoints)
        {
            float x = 0f;
            for (int i = 0; i < countPoints; i++)
            {
                x += 20;
                PointF p1 = new PointF(x, 295f);
                PointF p2 = new PointF(x, 305f);
                frameGraph.DrawLine(graphPen, p1, p2);
            }
        }
    }

    
}

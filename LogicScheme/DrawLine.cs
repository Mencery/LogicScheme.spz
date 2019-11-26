

using System.Collections.Generic;
using System.Drawing;


namespace LogicScheme
{
    class DrawLine
    {
        Point pointStart  = new Point();
         Point pointEnd =  new Point();
         List<TwoPoints>  twoPoints= new List<TwoPoints>();
        
        public void setStartPoint(int x, int y)
        {
            pointStart.X = x;
            pointStart.Y = y;
            pointEnd.X = x;
            pointEnd.Y = y;

        }
        public void draw(int x, int y)
        {
            if(!rangeX(x) && !rangeY(y))
            {
               
                    save();
                    pointStart.Y = pointEnd.Y;
                    pointStart.X = pointEnd.X;


            }
           
          if(rangeX(x) && !rangeY(y))
            {
               
              
                    x = pointStart.X;
               
               
            }

          
            else if(!rangeX(x) && rangeY(y))
            {
             
                    y = pointStart.Y;
                
              
                
               
            }
         
            
                pointEnd.X = x;
                pointEnd.Y = y;
            
            
        }
        /// <summary>
        /// save line that finished drawing
        /// </summary>
        public void save()
        {
            twoPoints.Add(new TwoPoints(pointStart, pointEnd));
        }
        /// <summary>
        /// delete line that didn't connect
        /// </summary>
        public void delete()
        {
            pointStart.X = 0;
            pointStart.Y = 0;
            pointEnd.X = 0;
            pointEnd.Y = 0;
            twoPoints.Clear();
        }
        public  Point getPointStart()
        {
            return pointStart;
        }
        public  Point getPointEnd()
        {
            return pointEnd;
        }
        public  List<TwoPoints> getTwoPoints()
        {
            return twoPoints;
        }
        /// <summary>
        /// range in which we can draw a straight line
        /// </summary>
        /// <param name="x,y">input position of cursor</param>
        /// <returns></returns>
        bool rangeX(int x )
        {
            int range = 7; 
            return x + range >= pointStart.X && x - range <= pointStart.X; 
        }
         bool rangeY(int y)
        {
            int range = 7;
            return y + range >= pointStart.Y && y - range <= pointStart.Y;
        }
    }
}

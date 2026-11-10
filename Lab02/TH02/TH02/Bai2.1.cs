using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TH02
{
    public class ArrayPoint
    {
        //Field
        public ArrayList ListPoint;
        //Constructor
        public ArrayPoint()
        {
            ListPoint = new ArrayList();
        }
        //Them Point vao danh sach
        public void Them(Point p)
        {
            ListPoint.Add(p);
        }
        // Indexer
        public Point this[int i]
        {
            get
            {
                return (Point)ListPoint[i];
            }
            set
            {
                ListPoint[i] = value;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public class Diamond : Shape
    {
        protected override Geometry DefiningGeometry
        {
            get
            {
                PathFigure myPathFigure = new PathFigure();
                myPathFigure.StartPoint = new Point(100, 0);

                LineSegment segment1 = new LineSegment();
                segment1.Point = new Point(200, 100);
                LineSegment segment2 = new LineSegment();
                segment2.Point = new Point(100, 200);
                LineSegment segment3 = new LineSegment();
                segment3.Point = new Point(0, 100);
                LineSegment segment4 = new LineSegment();
                segment4.Point = new Point(100, 0);

                PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
                myPathSegmentCollection.Add(segment1);
                myPathSegmentCollection.Add(segment2);
                myPathSegmentCollection.Add(segment3);
                myPathSegmentCollection.Add(segment4);

                myPathFigure.Segments = myPathSegmentCollection;

                PathFigureCollection myPathFigureCollection = new PathFigureCollection();
                myPathFigureCollection.Add(myPathFigure);

                PathGeometry myPathGeometry = new PathGeometry();
                myPathGeometry.Figures = myPathFigureCollection;

                return myPathGeometry;
            }
        }
    }
}

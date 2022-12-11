using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

public class OzelYapimSekil:Shape
{
    protected override Geometry DefiningGeometry
    {
        get { return GenerateCustomShape();  }
    }
    private Geometry GenerateCustomShape()
    {
        StreamGeometry stream=new StreamGeometry();
        using(StreamGeometryContext gc=stream.Open())
        {
            gc.BeginFigure(new Point(50.0,50.0),false,true)
        //    gc.ArcTo(new Point)
        }
    }
}

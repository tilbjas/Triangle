using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Polygon
{
    [DataContract]
    public abstract class AShape
    {
        public int height, width;
        public abstract double getArea();

    }
    [DataContract]
    public class RightAngletriangle : AShape
    {
        [DataMember]
        public int Height
        {
            get {return height;}
            set
            {
                if (value<=0)
                {
                     Exception e = new Exception("Width cannot be less than or equal to Zero");
                    throw e;
                }
                else 
                    height=value;
            }
        }
        [DataMember]
         public int Width
        {
            get {return width;}
            set
            {
                if (value<=0 ){
                    Exception e = new Exception("Width cannot be less than or equal to Zero");
                    throw e;
                }
                else 
                    width=value;
            }
        }
       
        override public double getArea()
        {
            double area = (Height * Width) / 2;
            return area;
        }
    }
}

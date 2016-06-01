using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Polygon
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        /*[OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        */
        [OperationContract]
        RightAngletriangle getRHT(int height, int width);

        [OperationContract]
        double getArea(RightAngletriangle RHT);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    /*[DataContract]
    public class RHT : RightAngletriangle
    {
        [DataMember]
        public int Height
        {
            get { return Height; }
            set { Height = value; }
        }
        [DataMember]
        public int Width
        {
            get { return Width; }
            set { Width = value; }
        }
    
    }*/
}

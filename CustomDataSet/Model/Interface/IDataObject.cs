using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDataSet.Model.EnumColleciton;

namespace CustomDataSet.Model.Interface
{
    public interface IDataContainerObject
    {
        string Name { get;  }
        string OjbectId { get; }
        DataObjectType DataObjectType { get; }
       
    }
}

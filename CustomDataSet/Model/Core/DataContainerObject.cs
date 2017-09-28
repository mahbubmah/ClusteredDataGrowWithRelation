using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CustomDataSet.Model.EnumColleciton;
using CustomDataSet.Model.Interface;

namespace CustomDataSet.Model.Core
{

    /// <summary>
    /// This class is the base class for all data container class
    /// </summary>
    public class DataContainerObject : IDataContainerObject
    {
        public string Name { get;private set; }
        /// <summary>
        /// Unique Object Identifier for every object of data set
        /// </summary>
        public string OjbectId { get; private set; }
        public DataObjectType DataObjectType { get; private set; }
        /// <summary>
        /// No one can create the object without it's name and type at least
        /// </summary>
        private DataContainerObject()
        {
            

        }
        /// <summary>
        /// Create new Data object like Table,Column,Row,Relation etc
        /// </summary>
        /// <param name="objectName">Object Name</param>
        /// <param name="objectType">Object Type</param>
        public DataContainerObject(string objectName, DataObjectType objectType)
        {
            DataObjectType = objectType;
            Name = objectName;
            OjbectId = Guid.NewGuid().ToString();
        }

        
    }
}

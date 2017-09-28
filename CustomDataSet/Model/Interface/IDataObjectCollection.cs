using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CustomDataSet.Model.Interface
{
    interface IDataObjectCollection
    {

       

        /// <summary>
        /// Add a dataObjectType object to column collection
        /// </summary>
        /// <param name="dataObject">dataObjectTypeName</param>
         void Add(IDataContainerObject dataObject);
        /// <summary>
        /// Add dataObjectTypeName to dataObjectType colleciton at specified index, if - provide for inddex the column will at at the last position of the list
        /// </summary>
        /// <param name="index">dataObject colleciton index. -1 indicate the last position</param>
        /// <param name="dataObject">data object</param>
         void AddAt(int index, IDataContainerObject dataObject);

        /// <devdoc>
        ///  Adds the dataObject to the dataObject array.
        /// </devdoc>
         void ArrayAdd(IDataContainerObject dataObject);

        /// <summary>
        /// Inset a dataObject to the data dataObject collection
        /// </summary>
        /// <param name="index"></param>
        /// <param name="column"></param>
        void ArrayAdd(int index, IDataContainerObject column);
    }
}

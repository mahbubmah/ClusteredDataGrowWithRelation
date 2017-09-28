using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDataSet.Model.Interface;

namespace CustomDataSet.Model.Core
{

    

    public abstract class BaseDataObjectColleciton : IDataObjectCollection
    {
       
       
       protected List<IDataContainerObject> DataObjectCollection { get; set; }
       /// <summary>
       /// Add a column object to column collection
       /// </summary>
       /// <param name="column"></param>
       public void Add(IDataContainerObject column)
       {
           AddAt(-1, column);
       }
       /// <summary>
       /// Add column to column colleciton at specified index, if - provide for inddex the column will at at the last position of the list
       /// </summary>
       /// <param name="index">column colleciton index. -1 indicate the last position</param>
       /// <param name="column">data column object</param>
       public void AddAt(int index, IDataContainerObject column)
       {
           
           if (index != -1)
               ArrayAdd(index, column);
           else
               ArrayAdd(column);
       }

       /// <devdoc>
       ///  Adds the column to the columns array.
       /// </devdoc>
      public  void ArrayAdd(IDataContainerObject column)
       {
           DataObjectCollection.Add(column);
         
       }
       /// <summary>
       /// Inset a column to the data column collection
       /// </summary>
       /// <param name="index"></param>
       /// <param name="column"></param>
       public void ArrayAdd(int index, IDataContainerObject column)
       {

           DataObjectCollection.Insert(index, column);
          
       }
    }
}

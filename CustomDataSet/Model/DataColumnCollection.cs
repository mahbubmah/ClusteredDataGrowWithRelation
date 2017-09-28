using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDataSet.Model.Core;
using CustomDataSet.Model.Interface;

namespace CustomDataSet.Model
{
    public class DataColumnCollection : BaseDataObjectColleciton
    {
       private readonly CusDataTable _table;
       private readonly Dictionary<string, CusDataColumn> _columnFromName;
       public List<IDataContainerObject> ColumnList
       {
           get { return base.DataObjectCollection; }
        }

        internal DataColumnCollection(CusDataTable table)
       {
           this._table = table;
           this._columnFromName=new Dictionary<string, CusDataColumn>();
       }
       /// <summary>
       /// Add column with name only. default data type for the column is string
       /// </summary>
       /// <param name="columnName">Column name</param>
       /// <returns></returns>
       public CusDataColumn Add(string columnName)
       {
           if (_columnFromName.ContainsKey(columnName))
           {
               throw new Exception("Column already exist with name " + column.Name);
           }
           Type type= typeof (string);
           CusDataColumn column = new CusDataColumn(columnName, type);
           Add(column);
           return column;
       }
       /// <summary>
       /// Add column with name and data type
       /// </summary>
       /// <param name="columnName">column name </param>
       /// <param name="type">data type of the column</param>
       /// <returns></returns>
       public CusDataColumn Add(string columnName, Type type)
       {
           if (_columnFromName.ContainsKey(columnName))
           {
               throw new Exception("Column already exist with name " + column.Name);
           }
           CusDataColumn column = new CusDataColumn(columnName, type);
           Add(column);
           return column;
       }
       

       
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDataSet.Model.Core;
using CustomDataSet.Model.EnumColleciton;

namespace CustomDataSet.Model
{
   public class CusDataTable : DataContainerObject
    {
       List<CusDataColumn> DataColumns { get; set; } 
       /// <summary>
       /// Constructor for CusDataTable
       /// </summary>
        /// <param name="tableCreationParamModel"></param>
       public CusDataTable(DataTableCreationParamModel tableCreationParamModel)
          : base(tableCreationParamModel.ObjectName, DataObjectType.Table)
       {
         
       }

    }

   /// <summary>
   /// Column Creation Parameter Model
   /// </summary>
   public class DataTableCreationParamModel : DataObjectCreationParamModel
   {
       
   }
}

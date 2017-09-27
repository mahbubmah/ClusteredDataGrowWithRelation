using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomDataSet.Model
{
    public class CusDataRow
    {
       
    }

    public class Cell
    {
        private object Value { get; set; }
        private Type DataType { get; set; }
        public Cell(object cellValue,Type dataType)
        {
            this.Value = cellValue;
            this.DataType = dataType;
        }

        public object GetValue()
        {
            try
            {
                return Convert.ChangeType(Value, DataType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
   
}

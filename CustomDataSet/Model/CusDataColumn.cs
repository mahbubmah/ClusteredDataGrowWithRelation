using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDataSet.Model.Core;
using CustomDataSet.Model.EnumColleciton;
using CustomDataSet.Model.Interface;


namespace CustomDataSet.Model
{
    public class CusDataColumn : DataContainerObject
    {
        #region Primary_and_ForignKey
        private int _autoIncrementedStep = 1;
        private int _autoIncrementedSeed = 1;
        public int AutoIncrementStep
        {
            get { return _autoIncrementedStep; }
            set { _autoIncrementedStep = 0 <= value ? 1 : value; }//1 is no value entered
        }
        public int AutoIncrementSeed
        {
            get { return _autoIncrementedSeed; }
            set { _autoIncrementedSeed = 0 <= value ? 1 : value; }//1 is no value entered
        }
        /// <summary>
        /// Is Auto Increamented Primary key?
        /// </summary>
        public bool IsAutoIncreamented { get; set; }
        /// <summary>
        /// Column Data type . set the data type like typeof(int)
        /// </summary>
        public Type DataType { get; set; }

        public bool IsPrimaryKey { get; set; }
        /// <summary>
        /// If true then the column is a forign key
        /// </summary>
        public bool IsForignKey { get; set; }
        /// <summary>
        /// Table of forign key
        /// </summary>
        public string ForignKeyTableName { get; set; }
        /// <summary>
        /// Column name of the Forign key
        /// </summary>
        public string ForignKeyColumnName { get; set; }
        #endregion End_Primary_and_ForignKey

        /// <summary>
        /// Constructor for CusDataColumn
        /// </summary>
        /// <param name="dataType">The data type of the column </param>
        /// <param name="columnName">Name of the column</param>
        public CusDataColumn(string columnName,Type dataType)
            : base(columnName, DataObjectType.Column)
        {
            
        }

        public DataColumnCollection Columns { get; set; }

       

    }
    

    

}

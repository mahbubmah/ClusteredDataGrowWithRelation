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
        
        private int _autoIncrementedStep = 1;
        private int _autoIncrementedSeed = 1;

        public int AutoIncrementStep
        {
            get { return _autoIncrementedStep; }
            set { _autoIncrementedStep = value==0?1:value; }//1 is no value entered
        }
        public int AutoIncrementSeed
        {
            get { return _autoIncrementedSeed; }
            set { _autoIncrementedSeed = value == 0 ? 1 : value; }//1 is no value entered
        }
       
        public bool IsAutoIncreamented { get;private set; }
        public Type DataType { get; private set; }
    
        public bool IsPrimaryKey { get; private set; }
        /// <summary>
        /// Constructor for CusDataColumn
        /// </summary>
        /// <param name="columnCreationParamModel"></param>
        public CusDataColumn(DataColumnCreationParamModel columnCreationParamModel)
            : base(columnCreationParamModel.ObjectName, DataObjectType.Column)
        {
            if (columnCreationParamModel.IsPrimaryKey && columnCreationParamModel.DataType != typeof (long))
            {
                throw new InvalidParameterValueException("Primary key can't be other than integer long");
            }
            if (columnCreationParamModel.IsForignKey && columnCreationParamModel.DataType != typeof(long))
            {
                throw new InvalidParameterValueException("Forign key can't be other than integer long");
            }
            this.DataType = columnCreationParamModel.DataType;
            this.IsPrimaryKey = columnCreationParamModel.IsPrimaryKey;
            this._autoIncrementedSeed = columnCreationParamModel.AutoIncrementSeed;
            this._autoIncrementedStep = columnCreationParamModel.AutoIncrementStep;
            this.IsAutoIncreamented = columnCreationParamModel.IsAutoIncremented;
            this.IsForignKey = columnCreationParamModel.IsForignKey;
            this.ForignKeyColumnName = columnCreationParamModel.ForignKeyColumnName;
            this.ForignKeyTableName = columnCreationParamModel.ForignKeyTableName;
        }

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

    }
    /// <summary>
    /// Column Creation Parameter Model
    /// </summary>
    public class DataColumnCreationParamModel : DataObjectCreationParamModel
    {
        /// <summary>
        /// set the data type like typeof(int)
        /// </summary>
        public Type DataType { get; set; }
        /// <summary>
        /// set this as true if you want this as primary key
        /// </summary>
        public bool IsPrimaryKey { get; set; }
        /// <summary>
        /// set the interval of autoincrement
        /// </summary>
        public int AutoIncrementStep { get; set; }
        /// <summary>
        /// set the start value of increamented value
        /// </summary>
        public int AutoIncrementSeed { get; set; }
        /// <summary>
        /// If true then the column will be auto incremented
        /// </summary>
        public bool IsAutoIncremented { get; set; }
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
    }

    public class InvalidParameterValueException : Exception
    {
        public InvalidParameterValueException(string message)
            : base(message)
        {
        }
        public InvalidParameterValueException(string message,Exception innerException)
            : base(message, innerException)
        {
        }
    }

}

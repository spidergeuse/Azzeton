using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Azzeton.Shared
{
    /// <summary>
    /// Managing searches
    /// </summary>
    public class SearchManager
    {
        /// <summary>
        /// Gets a string representation of enum value
        /// </summary>
        /// <param name="compareusing">Search type enum value</param>
        /// <returns>String representation</returns>
        public static string GetValueOf(ComparismType compareusing)
        {
            switch (compareusing)
            {
                case ComparismType.Equal:
                    return "=";
                case ComparismType.GreaterThan:
                    return ">";
                case ComparismType.LessThan:
                    return "<";
                case ComparismType.Like:
                case ComparismType.LikePost:
                case ComparismType.LikePre:
                    return "LIKE";
                case ComparismType.NotEqual:
                    return "<>";
                case ComparismType.GreaterThanOrEqualTo:
                    return ">=";
                case ComparismType.LessThanOrEqualTo:
                    return "<=";
                default:
                    return "=";

            }
        }
    }
    /// <summary>
    /// Parameter for searching/ building dynamic queries
    /// </summary>
    [Serializable()]
    public class SearchParameter
    {
        /// <summary>
        /// Name of parameter
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Value of the parameter
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// Type of Comparism
        /// </summary>
        public ComparismType CompareUsing { get; set; }
        /// <summary>
        /// Check for appropriate parsing for this value type
        /// </summary>
        public ParseType Parse { get; set; }
        /// <summary>
        /// Initialize SearchParameter
        /// </summary>
        public SearchParameter() { }
        /// <summary>
        /// Initialize SearchParameter
        /// </summary>
        /// <param name="name">Name of parameter</param>
        /// <param name="value">Value of parameter</param>
        public SearchParameter(string name, object value): this(name, value, ComparismType.Equal)
        {}
        /// <summary>
        /// Initialize SearchParameter
        /// </summary>
        /// <param name="name">Name of parameter</param>
        /// <param name="value">Value of parameter</param>
        /// <param name="compareusing">Comparism type</param>
        public SearchParameter(string name, object value, ComparismType compareusing):this(name,value,compareusing, ParseType.General )
        {}
        /// <summary>
        /// Initialize SearchParameter
        /// </summary>
        /// <param name="name">Name of parameter</param>
        /// <param name="value">Value of parameter</param>
        /// <param name="compareusing">Comparism type</param>
        /// <param name="parse">Parsing type</param>
        public SearchParameter(string name, object value, ComparismType compareusing, ParseType parse):this()
        {
            this.Name = name;
            this.Value = value;
            this.CompareUsing = compareusing;
            this.Parse = parse;
        }
    }
    /// <summary>
    /// Data Parameter
    /// For packing values to be saved. 
    /// Useful for dynamic queries
    /// </summary>
    [Serializable()]
    public class DataParameter
    {
        /// <summary>
        /// Name of parameter
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Value of the parameter
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// Type of parameter
        /// </summary>
        public ParameterType Type { get; set; }
        /// <summary>
        /// Initialize DataParameter
        /// </summary>
        public DataParameter() { }
        /// <summary>
        /// Initialize DataParameter
        /// </summary>
        /// <param name="name">Name of the parameter</param>
        /// <param name="value">Value of the parameter</param>
        public DataParameter(string name, object value):this(name,value, ParameterType.ProcedureParameter)
        { }
        /// <summary>
        /// Initialize DataParameter
        /// </summary>
        /// <param name="name">Name of the parameter</param>
        /// <param name="value">Value of the parameter</param>
        /// <param name="type">Type of parameter</param>
        public DataParameter(string name, object value, ParameterType type): this()
        {
            this.Value = value;
            this.Name = name;
            this.Type = type;
        }
    }
    /// <summary>
    /// Logical Options 
    /// Usedfor building dynamic queries
    /// </summary>
    public enum SearchUsing
    {
        AND,
        OR,
        NOTHING
    }
    /// <summary>
    /// Like type in queries
    /// Usedfor building dynamic queries
    /// </summary>
    public enum ComparismType
    {
        Like,
        LikePre,
        LikePost,
        Equal,
        GreaterThan,
        LessThan,
        GreaterThanOrEqualTo,
        LessThanOrEqualTo,
        NotEqual
    }
    /// <summary>
    /// Sorting type
    /// Usedfor building dynamic queries
    /// </summary>
    public enum SortBy
    {
        Ascending,
        Descending,
        None
    }
    /// <summary>
    /// Type of parameter
    /// </summary>
    public enum ParameterType
    {
        TableColumn,
        ProcedureParameter
    }
    /// <summary>
    /// Type of parsing
    /// </summary>
    public enum ParseType
    {
        Date,
        Time,
        General
    }
    /// <summary>
    /// Class to pack commands for execution
    /// </summary>
    [Serializable()]
    public class DataCommand
    {
        /// <summary>
        /// Initialize Command
        /// </summary>
        /// <param name="parameters">List of parameters</param>
        /// <param name="commandtext">Command Text</param>
        public DataCommand(List<DataParameter> parameters, string commandtext): this(parameters, commandtext, CommandType.StoredProcedure)
        {

        }
        /// <summary>
        /// Initialize Command
        /// </summary>
        /// <param name="parameters">List of parameters</param>
        /// <param name="commandtext">Command Text</param>
        /// <param name="commandtype">Type of command</param>
        public DataCommand(List<DataParameter> parameters, string commandtext, CommandType commandtype):this(parameters,new List<SearchParameter>(),commandtext)
        {
        }
        /// <summary>
        /// Initialize Command
        /// </summary>
        /// <param name="parameters">List of parameters</param>
        /// <param name="criteria">List of criteria</param>
        /// <param name="commandtext">Command Text</param>
        public DataCommand(List<DataParameter> parameters, List<SearchParameter> criteria, string commandtext): this(parameters, criteria, commandtext,CommandType.StoredProcedure)
        { }
        /// <summary>
        /// Initialize Command
        /// </summary>
        /// <param name="parameters">List of parameters</param>
        /// <param name="criteria">List of criteria</param>
        /// <param name="commandtext">Command Text</param>
        /// <param name="commandtype">Type of command</param>
        public DataCommand(List<DataParameter> parameters, List<SearchParameter> criteria, string commandtext, CommandType commandtype)
        {
            this.Parameters = parameters;
            this.Criteria = criteria;
            this.CommandText = commandtext;
            this.CommandType = commandtype;
        }
        /// <summary>
        /// List of Criteria for the command
        /// </summary>
        public List<SearchParameter> Criteria { get; set; }
        /// <summary>
        /// List of Parameter for the command
        /// </summary>
        public List<DataParameter> Parameters { get; set; }
        /// <summary>
        /// Command Text (Name of procedure or SQL query)
        /// </summary>
        public string CommandText { get; set; }
        /// <summary>
        /// Type of command
        /// </summary>
        public CommandType CommandType { get; set; }
    }
}

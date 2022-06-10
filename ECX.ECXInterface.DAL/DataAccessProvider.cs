﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECX.ECXInterface.DAL
{
    internal class DataAccessProvider
    {
        #region memberVariables

        #endregion

        #region memberMethods

        /// <summary>
        /// Method that returns DataSet after executing a stored procedure using select statment
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strSchema"></param>
        /// <param name="strStoredProcedureName"></param>
        /// <param name="arrListParamName"></param>
        /// <param name="arrListParamValue"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string strConnectionString, string strSchema, string strStoredProcedureName, ArrayList arrListParamName, ArrayList arrListParamValue, ref string strErrMsg)
        {
            SqlConnection connection = new SqlConnection(strConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            try
            {
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.CommandText = strSchema + "." + strStoredProcedureName;
                sqlDataAdapter.SelectCommand.Connection = connection;
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;

                for (int i = 0; i < arrListParamName.Count; i++)
                {
                    sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter(arrListParamName[i].ToString(), arrListParamValue[i].ToString()));
                }

                connection.Open();
                sqlDataAdapter.Fill(ds);
            }
            catch (Exception e)
            {
                strErrMsg = e.Message;
            }
            finally
            {
                if (connection.State.ToString() == System.Data.ConnectionState.Open.ToString())
                    connection.Close();

                sqlDataAdapter.Dispose();
            }

            return ds;
        }

        /// <summary>
        /// Method that returns DataTabe after executing a stored procedure using select statment
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strSchema"></param>
        /// <param name="strStoredProcedureName"></param>
        /// <param name="arrListParamName"></param>
        /// <param name="arrListParamValue"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string strConnectionString, string strSchema, string strStoredProcedureName, ArrayList arrListParamName, ArrayList arrListParamValue, ref string strErrMsg)
        {
            SqlConnection connection = new SqlConnection(strConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.CommandText = strSchema + "." + strStoredProcedureName;
                sqlDataAdapter.SelectCommand.Connection = connection;
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;

                for (int i = 0; i < arrListParamName.Count; i++)
                {
                    sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter(arrListParamName[i].ToString(), arrListParamValue[i].ToString()));
                }

                connection.Open();
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                strErrMsg = e.Message;
            }
            finally
            {
                if (connection.State.ToString() == System.Data.ConnectionState.Open.ToString())
                    connection.Close();

                sqlDataAdapter.Dispose();
            }

            return dt;
        }

        /// <summary>
        /// Method that returns DataTable by accepting user defined types
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strSchema"></param>
        /// <param name="strStoredProcedureName"></param>
        /// <param name="arrListParamName"></param>
        /// <param name="arrListParamValue"></param>
        /// <param name="arrListParamNameForUserDefinedTypes"></param>
        /// <param name="lstParameterValuesForUserDefinedTypes"></param>
        /// <param name="arrListParamterTypeNameForUserDefinedTypes"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string strConnectionString, string strSchema, string strStoredProcedureName, ArrayList arrListParamName, ArrayList arrListParamValue, ArrayList arrListParamNameForUserDefinedTypes, List<DataTable> lstParameterValuesForUserDefinedTypes, ArrayList arrListParamterTypeNameForUserDefinedTypes, ref string strErrMsg)
        {
            SqlConnection connection = new SqlConnection(strConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.CommandText = strSchema + "." + strStoredProcedureName;
                sqlDataAdapter.SelectCommand.Connection = connection;
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;

                for (int i = 0; i < arrListParamName.Count; i++)
                {

                    sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter(arrListParamName[i].ToString(), arrListParamValue[i].ToString()));
                }

                for (int k = 0; k < arrListParamNameForUserDefinedTypes.Count; k++)
                {
                    SqlParameter p = new SqlParameter(arrListParamNameForUserDefinedTypes[k].ToString(), lstParameterValuesForUserDefinedTypes[k]);
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = arrListParamterTypeNameForUserDefinedTypes[k].ToString();
                    sqlDataAdapter.SelectCommand.Parameters.Add(p);
                }

                connection.Open();
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                strErrMsg = e.Message;
            }
            finally
            {
                if (connection.State.ToString() == System.Data.ConnectionState.Open.ToString())
                    connection.Close();

                sqlDataAdapter.Dispose();
            }

            return dt;
        }

        /// <summary>
        /// Retrieve Non Parameter Storeprocedures
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strSchema"></param>
        /// <param name="strStoredProcedureName"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string strConnectionString, string strSchema, string strStoredProcedureName, ref string strErrMsg)
        {
            SqlConnection connection = new SqlConnection(strConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.CommandText = strSchema + "." + strStoredProcedureName;
                sqlDataAdapter.SelectCommand.Connection = connection;
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;


                connection.Open();
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                strErrMsg = e.Message;
            }
            finally
            {
                if (connection.State.ToString() == System.Data.ConnectionState.Open.ToString())
                    connection.Close();

                sqlDataAdapter.Dispose();
            }

            return dt;
        }


        /// <summary>
        /// Method that executes stored procedure with Insert, Delete, and Update methods
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strSchema"></param>
        /// <param name="strStoredProcedureName"></param>
        /// <param name="arrListParamName"></param>
        /// <param name="arrListParamValue"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        public static bool ExecuteNonQuery(string strConnectionString, string strSchema, string strStoredProcedureName, ArrayList arrListParamName, ArrayList arrListParamValue, ref string strErrMsg)
        {
            SqlConnection connection = new SqlConnection(strConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = strSchema + "." + strStoredProcedureName;
            command.Connection = connection;

            for (int i = 0; i < arrListParamName.Count; i++)
            {
                command.Parameters.Add(new SqlParameter(arrListParamName[i].ToString(), arrListParamValue[i] == null ? "" : arrListParamValue[i].ToString()));
            }

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                strErrMsg = e.Message;
            }
            finally
            {
                if (connection.State.ToString() == System.Data.ConnectionState.Open.ToString())
                    connection.Close();
            }
            return false;
        }

        /// <summary>
        /// Methods to return single value for example returning username by userid
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strSchema"></param>
        /// <param name="strStoredProcedureName"></param>
        /// <param name="arrListParamName"></param>
        /// <param name="arrListParamValue"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string strConnectionString, string strSchema, string strStoredProcedureName, ArrayList arrListParamName, ArrayList arrListParamValue, ref string strErrMsg)
        {
            SqlConnection connection = new SqlConnection(strConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = strSchema + "." + strStoredProcedureName;
            command.Connection = connection;

            for (int i = 0; i < arrListParamName.Count; i++)
            {
                command.Parameters.Add(new SqlParameter(arrListParamName[i].ToString(), arrListParamValue[i] == null ? "" : arrListParamValue[i].ToString()));
            }

            try
            {
                connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception e)
            {
                strErrMsg = e.Message;
            }
            finally
            {
                if (connection.State.ToString() == System.Data.ConnectionState.Open.ToString())
                    connection.Close();
            }
            return null;
        }

        /// <summary>
        /// Method that accepts DataTable dt and converts it to a generic list item. For this method to work DataTable schema shall be same as List propertis.
        /// this Method calls GetItem() to interate through each column of each row 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        try
                        {
                            T item = GetItem<T>(row);
                            data.Add(item);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
            return data;
        }

        /// <summary>
        /// Method that accepts DataRow object and iterates through each columns in the passed in DataRow and maps each to generic type T. Note that 
        /// for this method to work DataRow columns schema shall be same as the properties of the genric type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        if (dr[column.ColumnName] != DBNull.Value)
                        {
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        }
                    }
                    else
                        continue;
                }
            }
            return obj;
        }

        #endregion
    }
}

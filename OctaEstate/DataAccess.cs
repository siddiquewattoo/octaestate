using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctaEstate
{
    internal class DataAccess
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        IDictionary<string, dynamic> data;
        string table, primKey;
        public DataAccess(string table, string primKey)
        {
            conn = new MySqlConnection("server=localhost;uid=root;pwd=;database=octa_estate");
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            data = new Dictionary<string, dynamic>();
            this.table = table;
            this.primKey = primKey;
        }

        public IDictionary<string, dynamic> Save(IDictionary<string, dynamic> data)
        {
            try
            {
                string keys = "";
                string values = "";
                int n = data.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    KeyValuePair<string, dynamic> row = data.ElementAt(i);
                    keys += $"`{row.Key}`, ";
                    values += $"'{row.Value}', ";
                }
                keys += $"`{data.ElementAt(n - 1).Key}`";
                values += $"'{data.ElementAt(n - 1).Value}'";
                cmd.CommandText = $"INSERT INTO `{table}`({keys}) VALUES ({values})";
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    data["res"] = 1;
                    data[primKey] = cmd.LastInsertedId;
                    data["msg"] = "Inserted Success";
                }
                else
                {
                    data["res"] = 0;
                    data["msg"] = "Data Not Inserted. UnKnown Error";
                }
            }
            catch (Exception ex)
            {
                data["res"] = 0;
                data["msg"] = ex.Message;
            }
            finally 
            {
                conn.Close();
            }
            return data;
        }

        public IDictionary<string, dynamic> Update(IDictionary<string, dynamic> data, int id)
        {
            try
            {
                string query = "";
                int n = data.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    KeyValuePair<string, dynamic> row = data.ElementAt(i);
                    query += $"`{row.Key}`='{row.Value}',";
                }
                query += $"`{data.ElementAt(n - 1).Key}`='{data.ElementAt(n - 1).Value}'";
                cmd.CommandText = $"UPDATE `{table}` SET {query} WHERE `{primKey}`='{id}'";
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    data["res"] = 1;
                    data["msg"] = "Updated Success";
                }
                else
                {
                    data["res"] = 0;
                    data["msg"] = "Data Not Updated. UnKnown Error";
                }
            }
            catch (Exception ex)
            {
                data["res"] = 0;
                data["msg"] = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public IDictionary<string, dynamic> Delete(int id)
        {
            try
            {
                cmd.CommandText = $"DELETE FROM `{table}` WHERE `{primKey}`='{id}'";
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    data["res"] = 1;
                    data["msg"] = "Delete Success";
                }
                else
                {
                    data["res"] = 0;
                    data["msg"] = "Data Not Deleted. UnKnown Error";
                }
            }
            catch (Exception ex)
            {
                data["res"] = 0;
                data["msg"] = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public IDictionary<string, dynamic> SearchByID(int id)
        {
            MySqlDataReader r = null;
            try
            {
                data.Clear();
                cmd.CommandText = $"SELECT * FROM `{table}` WHERE `{primKey}`='{id}'";
                conn.Open();
                r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    List<dynamic> dataList = new List<dynamic>();
                    if (r.Read())
                    {
                        data.Clear();
                        for (int i = 0; i < r.FieldCount; i++)
                        {
                            data[r.GetName(i)] = r.GetString(i);
                        }
                        dataList.Add(data);
                    }
                    data.Add("dataTable", null);
                    data.Add("dataList", dataList);
                    data.Add("res", 1);
                }
                else 
                {
                    data["res"] = 0;
                    data["msg"] = "No Data Found.";
                }
            }
            catch (Exception ex)
            {
                data["res"] = 0;
                data["msg"] = ex.Message;
            }
            finally
            {
                r.Close();
                conn.Close();
            }
            return data;
        }
        public IDictionary<string, dynamic> loadTable()
        {
            MySqlDataReader r = null;
            DataTable dataTable = new DataTable();
            try
            {
                data.Clear();
                cmd.CommandText = $"SELECT * FROM `{table}`";
                conn.Open();
                r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    List<dynamic> dataList = new List<dynamic>();
                    while (r.Read())
                    {
                        data.Clear();
                        for (int i = 0; i < r.FieldCount; i++)
                        {
                            data[r.GetName(i)] = r.GetString(i);
                        }
                        dataList.Add(data);
                    }
                    r.Close();
                    r = cmd.ExecuteReader();
                    dataTable.Load(r);
                    data.Add("dataTable", dataTable);
                    data.Add("dataList", dataList);
                    data.Add("res", 1);
                }
                else
                {
                    data["res"] = 0;
                    data["msg"] = "No Data Found.";
                }
            }
            catch (Exception ex)
            {
                data["res"] = 0;
                data["msg"] = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return data;
        }
        public IDictionary<string, dynamic> SearchQuery(string query)
        {
            MySqlDataReader r = null;
            try
            {
                data.Clear();
                DataTable dataTable = new DataTable();
                cmd.CommandText = $"SELECT * FROM `{table}` WHERE {query}";
                conn.Open();
                r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    dataTable.Load(r);
                    List<dynamic> dataList = new List<dynamic>();
                    while (r.Read())
                    {
                        data.Clear();
                        for (int i = 0; i < r.FieldCount; i++)
                        {
                            data[r.GetName(i)] = r.GetString(i);
                        }
                        dataList.Add(data);
                    }
                    data.Add("dataTable", dataTable);
                    data.Add("dataList", dataList);
                    data.Add("res", 1);
                }
                else
                {
                    data["res"] = 0;
                    data["msg"] = "No Data Found.";
                }
            }
            catch (Exception ex)
            {
                data["res"] = 0;
                data["msg"] = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

    }
}

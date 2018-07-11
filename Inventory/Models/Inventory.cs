using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Inventory;

namespace Inventory.Models
{
  public class Wine
  {
    private string _wine;
    private int _id;

    public Wine (string wine, int Id = 0)
    {
      _wine = wine;
      _id = Id;
    }
    public string GetWine()
    {
      return _wine;
    }
    public int GetId()
    {
      return _id;
    }
    public static Wine Find(int id)
    {
      MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM `Wine` WHERE id = @thisId;";

        MySqlParameter thisId = new MySqlParameter();
        thisId.ParameterName = "@thisId";
        thisId.Value = id;
        cmd.Parameters.Add(thisId);

        var rdr = cmd.ExecuteReader() as MySqlDataReader;

        int itemId = 0;
        string itemWine = "";

        while (rdr.Read())
        {
            itemId = rdr.GetInt32(0);
            itemWine = rdr.GetString(1);
        }

        Wine foundWine= new Wine(itemWine, itemId);

         conn.Close();
         if (conn != null)
         {
             conn.Dispose();
         }

        return foundWine;
    }
    public static List<Wine> GetAll()
    {
      List<Wine> allWines = new List<Wine> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM Wine;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int itemId = rdr.GetInt32(0);
        string itemWine = rdr.GetString(1);
        Wine newWine = new Wine(itemWine, itemId);
        allWines.Add(newWine);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allWines;
    }
    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO `Wine` (`wine`) VALUES (@itemWine);";

      MySqlParameter wine = new MySqlParameter();
      wine.ParameterName = "@itemWine";
      wine.Value = this._wine;
      cmd.Parameters.Add(wine);


      cmd.ExecuteNonQuery();
      _id = (int) cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
    public override bool Equals(System.Object otherWine)
    {
      if (!(otherWine is Wine))
      {
        return false;
      }
      else
      {
        Wine newWine = (Wine) otherWine;
        bool idEquality = (this.GetId() == newWine.GetId());
        bool yachtEquality = (this.GetWine() == newWine.GetWine());
        return (idEquality && yachtEquality);
      }
    }
    public static void DeleteAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM Wine;";

      cmd.ExecuteNonQuery();

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

  }
  public class Yacht
  {
    private string _yacht;
    private int _id;

    public Yacht (string yacht, int Id = 0)
    {
      _yacht = yacht;
      _id = Id;
    }
    public string GetYacht()
    {
      return _yacht;
    }
    public int GetId()
    {
      return _id;
    }
    public static Yacht Find(int id)
    {
      MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM `Inventory` WHERE id = @thisId;";

        MySqlParameter thisId = new MySqlParameter();
        thisId.ParameterName = "@thisId";
        thisId.Value = id;
        cmd.Parameters.Add(thisId);

        var rdr = cmd.ExecuteReader() as MySqlDataReader;

        int itemId = 0;
        string itemYacht = "";

        while (rdr.Read())
        {
            itemId = rdr.GetInt32(0);
            itemYacht = rdr.GetString(1);
        }

        Yacht foundYacht= new Yacht(itemYacht, itemId);

         conn.Close();
         if (conn != null)
         {
             conn.Dispose();
         }

        return foundYacht;
    }
    public static List<Yacht> GetAll()
    {
      List<Yacht> allYachts = new List<Yacht> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM Inventory;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int itemId = rdr.GetInt32(0);
        string itemYacht = rdr.GetString(1);
        Yacht newYacht = new Yacht(itemYacht, itemId);
        allYachts.Add(newYacht);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allYachts;
    }
    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO `Inventory` (`yacht`) VALUES (@itemYacht);";

      MySqlParameter yacht = new MySqlParameter();
      yacht.ParameterName = "@itemYacht";
      yacht.Value = this._yacht;
      cmd.Parameters.Add(yacht);

      cmd.ExecuteNonQuery();
      _id = (int) cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
    public override bool Equals(System.Object otherYacht)
    {
      if (!(otherYacht is Yacht))
      {
        return false;
      }
      else
      {
        Yacht newYacht = (Yacht) otherYacht;
        bool idEquality = (this.GetId() == newYacht.GetId());
        bool yachtEquality = (this.GetYacht() == newYacht.GetYacht());
        return (idEquality && yachtEquality);
      }
    }
    public static void DeleteAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM Inventory;";

      cmd.ExecuteNonQuery();

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

  }
}

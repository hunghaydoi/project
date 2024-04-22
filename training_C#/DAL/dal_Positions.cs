using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal_Positions
    {
        public static DataTable getAllData()
        {
            SqlDataAdapter da = new SqlDataAdapter("TM_Positions_getAllData",dal_ConnectDB.connect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable TM_Positions_Check_ID(string positionID)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            SqlCommand cmd = new SqlCommand("TM_Positions_Check_ID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@positionID", positionID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool TM_Positions_Insert(dto_Position dto_position)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Positions_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PositionID", dto_position.PositionID);
            cmd.Parameters.AddWithValue("@PositionName", dto_position.PositionName);
            if (cmd.ExecuteNonQuery() != 0)
            {
                conn.Close();
                return true;
            }
            return false;

        }
        public static bool TM_Positions_Update(dto_Position dto_position)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Positions_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PositionID", dto_position.PositionID);
            cmd.Parameters.AddWithValue("@PositionName", dto_position.PositionName);
            if (cmd.ExecuteNonQuery() != 0)
            {
                conn.Close();
                return true;
            }
            return false;

        }
        public static bool TM_Positions_Delete(string positionID)
        {
            SqlConnection conn = dal_ConnectDB.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TM_Positions_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PositionID", positionID);
            if (cmd.ExecuteNonQuery() != 0)
            {
                conn.Close();
                return true;
            }
            return false;

        }
    }
}

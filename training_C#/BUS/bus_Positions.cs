using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class bus_Positions
    {
        public static DataTable getAllData()
        {
            return dal_Positions.getAllData();
        }
        public static DataTable TM_Positions_Check_ID(string dto_position)
        {
            return dal_Positions.TM_Positions_Check_ID(dto_position);
        }
        public static bool TM_Positions_Insert(dto_Position dto_position)
        {
            return dal_Positions.TM_Positions_Insert (dto_position);
        }
        public static bool TM_Positions_Update(dto_Position dto_position)
        {
            return dal_Positions.TM_Positions_Update(dto_position);
        }
        public static bool TM_Positions_Delete(string PositionID)
        {
            return dal_Positions.TM_Positions_Delete(PositionID);
        }
    }
}

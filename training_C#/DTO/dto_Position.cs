using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_Position
    {
        private string _PositionID;
        private string _PositionName;
        public string PositionID { get { return _PositionID; } set {  _PositionID = value; } }
        public string PositionName { get { return _PositionName; } set { _PositionName = value; } }

        public dto_Position(string positionID, string positionName) 
        {
            this.PositionID = positionID;
            this.PositionName = positionName;   
        }
    }
}

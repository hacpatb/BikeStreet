using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeStreet
{
    public class cEquiomentsInContract
    {
        public int id_equioment_in_contract { get; set; }
        public int equioment_in_contract { get; set; }
        public int id_equipment { get; set; }

        public cEquiomentsInContract()
        {
            db db = new db();
            if (db.dbOpen())
            {
                id_equioment_in_contract = -1;//1 + Convert.ToInt32(db.executeScalar("SELECT COUNT(*) FROM equioments_in_contract"));
            }
            db.dbClose();

        }
    }

}

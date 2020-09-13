using POO3A96.DAL;
using System.Data;
using POO3A96.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A96.BLL
{
    class tbl_CDBLL
    {
        private DALBD daoBanco = new DALBD();

        public DataTable ListarCDs()
        {
            string sql = string.Format($@"select * from TBL_CD");
            return daoBanco.ExecutarConsulta(sql);
        }

    }
}

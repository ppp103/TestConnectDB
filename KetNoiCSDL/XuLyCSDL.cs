using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KetNoiCSDL
{
    class XuLyCSDL
    {
        string strConnect = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().ToString() + "\\DataBase\\" +
                "DuLieu.mdf;Integrated Security=True";
        SqlConnection sqlConnect = null;

        private void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(strConnect);
        }
    }
}

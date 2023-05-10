using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prjCustomerSystem.Models
{
    public class CStaffManager
    {
        public CStaffManager()
        {
            DataLoad();
        }

        public CStaff queryByEmail(string email)
        {
            foreach(CStaff c in _list)
            {
                if(c.email == email)
                    return c;
            }
            return null;
        }

        List<CStaff> _list = new List<CStaff>();
        int _position = -1;
        public void DataLoad()
        {
            CStaff x = new CStaff();
            x.id = "001";
            x.name = "Jokic";
            x.phone = "0936843381";
            x.email = "jokic@gmail.com";
            x.address = "Hualien";
            x.password = "1234";
            _list.Add(x);

            x = new CStaff();
            x.id = "002";
            x.name = "Allen";
            x.phone = "0917400198";
            x.email = "p268955@gmail.com";
            x.address = "Hsinchu";
            x.password = "1234";
            _list.Add(x);

            x = new CStaff();
            x.id = "003";
            x.name = "Jimmy";
            x.phone = "0919915962";
            x.email = "jimmy@outlook.com";
            x.address = "Chupei";
            x.password = "1234";
            _list.Add(x);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCustomerSystem.Models
{

    public class CCustomerManager
    {
        public CCustomerManager()
        {
            DataLoad();
        }
        List<CCustomer> _list = new List<CCustomer>();
        int _position = -1;
        public void DataLoad()
        {
            CCustomer x = new CCustomer();
            x.id = "001";
            x.name = "Marco";
            x.phone = "0933654125";
            x.email = "marco@gmail.com";
            x.address = "Taipei";
            _list.Add(x);

            x = new CCustomer();
            x.id = "002";
            x.name = "Selina";
            x.phone = "0966541258";
            x.email = "selina@gmail.com";
            x.address = "New Taipei";
            _list.Add(x);

            x = new CCustomer();
            x.id = "008";
            x.name = "Kymbia";
            x.phone = "0932448559";
            x.email = "kymbia@outlook.com";
            x.address = "TaiChung";
            _list.Add(x);
        }

        public void moveFirst()
        {
            _position = 0;
        }
        public void movePrevious()
        {
            _position--;
            if (_position < 0)
                _position = 0;
        }
        public void moveNext()
        {
            _position++;
            if (_position >= _list.Count)
                _position = _list.Count - 1;

        }
        public void moveLast()
        {
            _position = _list.Count - 1;
        }

        public void moveTo(int to)
        {
            _position = to;
        }

        public CCustomer current { get { return _list[_position]; } }

        public List<CCustomer> all {  get { return _list; } }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мероприятия1
{
    internal class Instance
    {
        public static МероприятияEntities1 _db = null;
        public static МероприятияEntities1 db
        {
            get
            {
                if (_db == null)
                {
                    _db = new МероприятияEntities1();
                }
                return _db;
            }
        }
    }
}

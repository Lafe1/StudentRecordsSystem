using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentRecordsSystem.Db
{
    class Parents
    {
        public int Id_Parent { get; set; }

        public int Id_Student { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public string Address { get; set; }

        public string Number { get; set; }
    }
}

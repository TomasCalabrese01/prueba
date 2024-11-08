﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.Interfaces
{
    internal interface IJsonConverter
    {
        string RowToJson(DataRow Dr);
        string TableToJson(DataTable Dt);
    }
}

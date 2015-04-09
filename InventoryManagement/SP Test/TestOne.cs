using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace InventoryManagement.SP_Test
{
    /// <summary>
    /// Parameters object for the 'testoneproc' stored procedure
    /// </summary>
    public class testone
    {
        // Override the parameter name. The parameter name is "in",
        // but that's not a valid property
        // name in C#, so we must name the property
        // something else and provide an override to set 
        // the parameter name.
        [StoredProcAttributes.Name("in")]
        [StoredProcAttributes.ParameterType(System.Data.SqlDbType.VarChar)]
        public String inparm { get; set; }

        // This time we not only override the parameter name, we're also setting the parameter
        // direction, indicating that this property will only receive data, not provide data
        // to the stored procedure. Note that we must include the size in bytes.
        [StoredProcAttributes.Name("out")]
        [StoredProcAttributes.Direction(System.Data.ParameterDirection.Output)]
        [StoredProcAttributes.Size(4)]
        public Int32 outparm { get; set; }
    }

    /// <summary>
    /// Results object for the 'testoneproc' stored procedure
    /// </summary>
    public class TestOneResultSet
    {
        [StoredProcAttributes.Name("table_name")]
        public string table { get; set; }

        [StoredProcAttributes.Name("column_name")]
        public string column { get; set; }
    }
}
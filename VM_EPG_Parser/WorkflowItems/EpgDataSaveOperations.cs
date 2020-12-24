using Epg.DataAccess.Concrete;
using Epg.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace VM_EPG_Parser.WorkflowItems
{
    public class EpgDataSaveOperations
    {
        public static void InsertUpdateEpgData(TVADBMainEntities tVADBMainEntities)
        {
            EpgDataAccess epgDA = new EpgDataAccess(ParserMain.Configuration);

            //TOD: need to return success or failure message
            epgDA.InsertUpdate(tVADBMainEntities);
        }
    }
}

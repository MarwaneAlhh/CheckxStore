using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckxxStore
{
    internal class QuerySql
    {
        public static String queryAllStore = "use usicoal\n"
                + "select WS.STORE_NO, bc.BRANCHNAME ,BC.COUNTRY, BC.COMPANYCODE, BC.COMPANYNAME ,sl.RLAREA, count(WS.WORKSTATION_NAME) as [TILLCOUNT], wg.WRKST_GRP_NO, wg.WRKST_GRP_NAME, BC.INACTIVE, sl.RLBTYP\n"
                + "from WORKSTATION WS\n"
                + "join common.dbo.BranchCodes BC on BC.brlocd = WS.store_no\n"
                + "left join WORKSTATION_GROUP wg on wg.WRKST_GRP_NO = ws.WRKST_GRP_NO\n"
                + "left join common.dbo.StkLoc sl on sl.RLLOCD = cast(BC.brlocd as varchar)\n"
                + "    where BC.INACTIVE in (0,1)\n"
                + "    and BC.COUNTRY not in ('GB','IE','ZA','MY')\n"
                + "    and BC.BRLOCD not in (976,984,985,986,992,997,998,1996,1998,1994,1995,1991,1999,9999)\n"
                + "    and BC.country in ('BE','NL','LU','FR','PL','CY','PT','ES','CZ','EE','DE','AT','HU','IS','LT','LV','SK','SI','IE')\n"
                + "group by WS.STORE_NO, bc.BRANCHNAME, BC.COUNTRY, BC.COMPANYCODE, BC.COMPANYNAME ,sl.RLAREA, wg.WRKST_GRP_NO, wg.WRKST_GRP_NAME, BC.INACTIVE,sl.RLBTYP\n";
    }
}

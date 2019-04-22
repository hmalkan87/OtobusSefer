using OtobusSefer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusSefer.BLL
{
    public static class DuraklarBLL
    {
        public static List<Duraklar> GetDuraklarNerden()
        {
            SeferiEntities dataContext = new SeferiEntities();
            return dataContext.Duraklars.ToList();
            
        }

        public static List<GuzergahDuraklari> GetDuraklarNereye(int nerdenID)
        {
            SeferiEntities dataContext = new SeferiEntities();
            int[] nerdenIDList = { nerdenID };
            var h = (from x in dataContext.GuzergahDuraklaris
                                                         where nerdenIDList.Contains(x.DurakID)
                                                         select x.GuzergahID).ToList();

            List<GuzergahDuraklari> gz = (from y in dataContext.GuzergahDuraklaris where h.Contains(y.DurakID) select y.GuzergahID).ToList();
            

            var a = from x in dataContext.GuzergahDuraklaris
                    where nerdenIDList.Contains(x.DurakID)
                    select new { x.GuzergahID };

            a.ToList();


            List<GuzergahDuraklari> gg = (from x in guzergahDuraklari
             
             select x).ToList();
            //guzergahDuraklari Select(a => ).ToList();


            //return guzergahDuraklari;
            //return gg;
        }

        public static object GetDuraklarNereye2(int nerdenID)
        {
            SeferiEntities dataContext = new SeferiEntities();
            int[] nerdenIDList = { nerdenID };
            var a = from x in dataContext.GuzergahDuraklaris
                    where nerdenIDList.Contains(x.DurakID)
                    select new { x.GuzergahID };

            return a.ToList();
        }
    }
}

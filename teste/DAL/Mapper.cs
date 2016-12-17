using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public interface Mapper<T>
    {
        //void MapObject(source, object destination);
        

        
        //public void MapObject(ref object source, ref object destination)
        //{
        //    try
        //    {
        //        Type sourceType = source.GetType();
        //        Type destinationTipe = destination.GetType();

        //        var sourceProperties = sourceType.GetProperties();
        //        var destinationProperties = destinationTipe.GetProperties();

        //        var commonProperties = from sp in sourceProperties
        //                               join dp in destinationProperties on new { sp.Name, sp.PropertyType } equals
        //                                                                   new { dp.Name, dp.PropertyType }
        //                               select new { sp, dp };
        //        foreach ( var match in commonProperties)
        //        {
        //            match.dp.SetValue(destination, match.sp.GetValue(source, null), null);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return;
                
        //    }
        //}
    }
}

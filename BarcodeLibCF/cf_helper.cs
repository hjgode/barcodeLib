using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeLib
{
    public static class myInt32
    {
        public static bool TryParse(string sData, out System.Int32 val)
        {
#if PocketPC
            bool bRet = false;
            System.Int32 test = 0;
            try
            {
                test = Convert.ToInt32(sData);
                bRet = true;
            }
            catch (Exception)
            {
            }
            val = test;
            return bRet;
#else
            return Int32.TryParse(sData, out val);
#endif
        }
    }
    public static class myInt64
    {
        public static bool TryParse(string sData, out System.Int64 i64value){
            bool bRet = false;
	        System.Int64 test=0;
            try 
	        {	        
                test = Convert.ToInt64(sData);
                bRet = true;
	        }
	        catch (Exception)
	        {
	        }
            i64value = test;
            return bRet;
        }
    }
    public static class @long
    {
        public static bool TryParse(string sData, out long _long)
        {
            bool bRet = false;
            System.Int64 test = 0;
            try
            {
                test = Convert.ToInt64(sData);
                bRet = true;
            }
            catch (Exception)
            {
            }
            _long = test;
            return bRet;
        }
    }
    class cf_helper
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porxy.PorxyDP
{
    class ProxyKullaniciBilgi:IKullaniciBilgi
    {
     private BTKKullaniciBilgileri objeBilgi;
        private Boolean LoadRealObje;
        private string userinfo = string.Empty;

        private string getUserInformationFromBTK()
        {
            try
            {
                objeBilgi = new BTKKullaniciBilgileri();
                LoadRealObje = true;
                userinfo = objeBilgi.getUserInformation();
                return userinfo;
            }
            catch
            {
                LoadRealObje =false;
                return "";

            } 
           
        }
        public string getUserInformation()
        {
            LoadRealObje = false;
            string result = "";
            if(objeBilgi==null)
            {
                result = getUserInformationFromBTK();
            }
            if (!LoadRealObje)
                return userinfo+"  Gerçek Obje Değil";
            else
            {
                return result;
            }
            
        }

    }
}

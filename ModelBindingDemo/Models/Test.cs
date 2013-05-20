using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplicationCustomModelBinder.Models
{
    public class ClasseDaAna
    {
        private ClasseDaAna()
        {
            
        }

        private static ClasseDaAna _instance;
        public static ClasseDaAna Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new ClasseDaAna();

                return _instance;
            }
        }
    }

    public class ClasseDoThiago
    {
        public void Teste()
        {
            var classeDaAna = ClasseDaAna.Instance;
        }
    }
}
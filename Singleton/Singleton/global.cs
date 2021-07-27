using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    sealed class Global
    {
        public string test { get; set; }
        private static Global _instance = null;

        private Global()
        {
        }

        static internal Global Instance()
        {
            if (_instance == null)
            {
                _instance = new Global();
            }

            return _instance;
        }
    }
}

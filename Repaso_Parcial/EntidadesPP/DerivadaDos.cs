using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public class DerivadaDos: Base
    {

        public DerivadaDos():base(1,0) { }

        public override string MostrarVersion()
        {
            return base.MostrarVersion();
        }

        public override string VersionFull
        {
            get { return this.MostrarVersion(); }
        }


    }
}

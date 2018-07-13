using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public sealed class DerivadaUno : Base
    {

        public int revision;

        static DerivadaUno() { }

        public DerivadaUno(int version, int sub, int revision):base(version, sub)
        {
            this.revision = revision;
        }

        public override string MostrarVersion()
        {
            return base.MostrarVersion() + string.Format("{0}",revision);
        }

        public override string VersionFull
        {
            get { return this.MostrarVersion(); }
        }



    }
}

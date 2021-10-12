using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakForm
{
  class Fajta
  {
    private int id;

    public int Id
    {
      get { return id; }
    }

    private string fajtaNev;

    public string FajtaNev
    {
      get { return fajtaNev; }
    }

    private string eredetiNev;

    public string EredetiNev
    {
      get { return eredetiNev; }
    }

    public Fajta(int id, string fajtaNev, string eredetiNev)
    {
      this.id = id;
      this.fajtaNev = fajtaNev;
      this.eredetiNev = eredetiNev;
    }
  }
}

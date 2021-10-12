using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakForm
{
  class Nev
  {
    private int id;

    public int Id
    {
      get { return id; }
    }

    private string kutyaNev;

    public string KutyaNev
    {
      get { return kutyaNev; }
    }

    public Nev(int id, string kutyaNev)
    {
      this.id = id;
      this.kutyaNev = kutyaNev;
    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowFleet
{
    public partial class FleetGrid : Component
    {
        public FleetGrid()
        {
            InitializeComponent();
        }

        public FleetGrid(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

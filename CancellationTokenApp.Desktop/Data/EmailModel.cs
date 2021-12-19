using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancellationTokenApp.Desktop.Data
{
    public class EmailModel
    {
        public Guid Id { get; set; }

        public string To { get; set; }
        public bool WaitingForSent { get; set; }

        public bool HasAttachment { get; set; }
    }
}

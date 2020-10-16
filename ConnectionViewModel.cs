using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSP_2
{
    class ConnectionViewModel : INotifyPropertyChanged
    {
        private VertexViewModel v1 = null;
        private VertexViewModel v2 = null;

        public ConnectionViewModel(VertexViewModel v1, VertexViewModel v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public VertexViewModel V1
        {
            get => v1;
            set
            {
                v1 = value;
                OnPropertyChanged("V1");
            }
        }

        public VertexViewModel V2
        {
            get => v2;
            set
            {
                v2 = value;
                OnPropertyChanged("V2");
            }
        }

        #region INotifyPropertyChanged Members

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}

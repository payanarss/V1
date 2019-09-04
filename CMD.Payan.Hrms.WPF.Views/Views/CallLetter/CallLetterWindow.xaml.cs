using Payanar.SS.Net.Libraries.Common;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CMD.Payan.Hrms.WPF.Views.Views.CallLetter
{
    /// <summary>
    /// Interaction logic for CallLetterWindow.xaml
    /// </summary>
    public partial class CallLetterWindow : Window, IView
    {
        public CallLetterWindow()
        {
            InitializeComponent();
            CallLetterPresenterInstance = new Presenters.CallLetterPresenter(this);
            this.DataContext = CallLetterPresenterInstance.CallLetterPresentationEntityDetail;
        }

        private CMD.Payan.Hrms.Presenters.CallLetterPresenter CallLetterPresenterInstance { get; set; }

        ////public string PageName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ////public int DataLoadedWeightage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ////public IView ParentDetail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ////public IViewFactory RightExplorerViewFactory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ////public IViewFactory BottomExplorerViewFactory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ////public IViewContext ViewContextDetail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        ////public IPresenter PresenterDetail => throw new NotImplementedException();

        public IObservable GetObservable()
        {
            throw new NotImplementedException();
        }

        public void LoadDatas()
        {
            throw new NotImplementedException();
        }

        public void ReLoadDatas()
        {
            throw new NotImplementedException();
        }

        public void ResetBinding()
        {
            throw new NotImplementedException();
        }

        public DialogResult ShowErrorMessage(string message)
        {
            throw new NotImplementedException();
        }

        public DialogResult ShowOkCancelMessage(string message)
        {
            throw new NotImplementedException();
        }

        public DialogResult ShowSuccessMessage(string message)
        {
            throw new NotImplementedException();
        }

        public DialogResult ShowWarningMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateObserver(object value)
        {
            throw new NotImplementedException();
        }

        public void UpdateObserver(object value, string message)
        {
            throw new NotImplementedException();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }

        public IViewFactory BottomExplorerViewFactory
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int DataLoadedWeightage
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string PageName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IView ParentDetail
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IPresenter PresenterDetail
        {
            get { throw new NotImplementedException(); }
        }

        public IViewFactory RightExplorerViewFactory
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IViewContext ViewContextDetail
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}

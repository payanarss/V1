using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Payanar.SS.Net.Libraries.Common;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.WPF.Views
{
    /// <summary>
    /// Interaction logic for BaseUserControl.xaml
    /// </summary>
    public partial class BaseUserControl : UserControl
    {
        public BaseUserControl()
        {
            InitializeComponent();
        }

        ////static BaseUserControl()
        ////{
        ////    DefaultStyleKeyProperty.OverrideMetadata(typeof(BaseUserControl), new FrameworkPropertyMetadata(typeof(BaseUserControl)));
        ////}

        ////#region Private Variables

        ////private IObserver _observerDetail;
        ////private IObservable _observableDetail;
        ////private string _title = string.Empty;

        ////#endregion Private Variables

        ////#region Constructors

        ////public BaseUserControl()
        ////{
        ////}

        ////public BaseUserControl(IViewContext viewContext)
        ////    : this()
        ////{
        ////}

        ////public BaseUserControl(IViewContext viewContext, IPresenterFactory presenterFactory)
        ////    : this(viewContext)
        ////{
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(this);
        ////}

        ////public BaseUserControl(IPresenterFactory presenterFactory)
        ////    : this()
        ////{
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(this);
        ////}

        ////public BaseUserControl(IPresenterFactory presenterFactory, IPresentationEntity presentationEntity)
        ////    : this()
        ////{
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(this, presentationEntity);
        ////}

        ////public BaseUserControl(IViewContext viewContext, IPresenterFactory presenterFactory, IPresentationEntity presentationEntity)
        ////    : this(viewContext)
        ////{
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(this, presentationEntity);
        ////}

        ////public BaseUserControl(IViewContext viewContext, IObserver observer, IPresenterFactory presenterFactory)
        ////    : this(viewContext)
        ////{
        ////    ObserverDetail = observer;
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(observer, this);
        ////    //GetObservable().AddObserver(observer);
        ////}

        ////public BaseUserControl(IObserver observer, IPresenterFactory presenterFactory)
        ////    : this()
        ////{
        ////    ObserverDetail = observer;
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(observer, this);
        ////    //GetObservable().AddObserver(observer);
        ////}

        ////public BaseUserControl(IObserver observer, IPresenterFactory presenterFactory, IPresentationEntity presentationEntity)
        ////    : this()
        ////{
        ////    ObserverDetail = observer;
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(observer, this, presentationEntity);
        ////    //GetObservable().AddObserver(observer);
        ////}

        ////public BaseUserControl(IPresenterFactory presenterFactory, IParent parent)
        ////    : this()
        ////{
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(this, parent);
        ////}

        ////public BaseUserControl(IObserver observer, IPresenterFactory presenterFactory, IParent parent)
        ////    : this()
        ////{
        ////    ObserverDetail = observer;
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(observer, this, parent);
        ////}

        ////#endregion Constructors

        ////#region Properties

        ////protected string Message
        ////{
        ////    get
        ////    {
        ////        string message = string.Empty;

        ////        message = ViewContextDetail != null ? ViewContextDetail.Message : string.Empty;

        ////        return message;
        ////    }
        ////}

        ////protected IObserver ObserverDetail
        ////{
        ////    get { return _observerDetail; }
        ////    private set { _observerDetail = value; }
        ////}

        ////protected IObservable ObservableDetail
        ////{
        ////    get
        ////    {
        ////        if (_observableDetail == null)
        ////        {
        ////            _observableDetail = Observable.Create();
        ////        }

        ////        return _observableDetail;
        ////    }
        ////}

        ////public IPresenter PresenterDetail { get; private set; }

        ////public IView ParentDetail { get; set; }

        ////protected IPresenterFactory PresenterFactoryDetail { get; set; }

        ////public IViewContext ViewContextDetail { get; set; }

        ////protected IPresentationEntity PresentationEntityDetail { get { return PresenterDetail == null ? null : PresenterDetail.PresentationEntityDetail; } }

        ////protected IPresentationEntityCollection PresentationEntityCollectionDetail
        ////{
        ////    get { return PresenterDetail != null ? PresenterDetail.PresentationEntityCollectionDetail : null; }
        ////    set
        ////    {
        ////        if (PresenterDetail != null)
        ////        {
        ////            PresenterDetail.PresentationEntityCollectionDetail = value;
        ////        }
        ////    }
        ////}

        ////public int DataLoadedWeightage { get; set; }

        ////public string Title
        ////{
        ////    get { return _title; }
        ////    set
        ////    {
        ////        _title = value;
        ////    }
        ////}

        ////public string PageName { get; set; }

        ////public IViewFactory RightExplorerViewFactory { get; set; }

        ////public ViewFactory BottomExplorerViewFactory { get; set; }
        ////IViewFactory IView.BottomExplorerViewFactory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        ////#endregion Properties

        ////#region Methods

        ////public virtual void LoadDatas()
        ////{
        ////    if (PresenterDetail != null)
        ////    {
        ////        PresenterDetail.OnViewReady();
        ////        InitializeDataSources();
        ////        ClearBindings();
        ////        ApplyBindings();
        ////    }
        ////}

        ////public virtual void ReLoadDatas()
        ////{
        ////    if (PresenterDetail != null)
        ////    {
        ////        PresenterDetail.OnViewReady();
        ////        InitializeDataSources();
        ////        ClearBindings();
        ////        ApplyBindings();
        ////    }
        ////}

        ////public virtual void ResetBinding()
        ////{
        ////    ClearBindings();
        ////    ApplyBindings();
        ////}

        ////protected virtual void InitializeDataSources()
        ////{
        ////}

        ////protected virtual void ApplyBindings() { }

        ////protected virtual void ClearBindings() { }

        ////protected virtual void OnCloseClicked() { }

        ////protected Binding AddBinding(string propertyName, string dataMember)
        ////{
        ////    return AddBinding(propertyName, PresentationEntityDetail, dataMember);
        ////}

        ////protected Binding AddBinding(string propertyName, object dataSource, string dataMember)
        ////{
        ////    return null;
        ////    ////return new Binding(propertyName, dataSource, dataMember);
        ////}

        ////protected void SetPresenterFactory(IPresenterFactory presenterFactory)
        ////{
        ////    PresenterFactoryDetail = presenterFactory;
        ////    PresenterDetail = PresenterFactoryDetail.Instance(this);
        ////}

        ////public Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.DialogResult ShowOkCancelMessage(string message)
        ////{
        ////    return Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.DialogResult.OK;
        ////    ////return UserMessage.ShowOkCancelMessage(message);
        ////}

        ////public Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.DialogResult ShowSuccessMessage(string message)
        ////{
        ////    return Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.DialogResult.OK;
        ////    ////return UserMessage.ShowSuccessMessage(message);
        ////}

        ////public Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.DialogResult ShowWarningMessage(string message)
        ////{
        ////    return Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.DialogResult.OK;
        ////    ////return UserMessage.ShowWarningMessage(message);
        ////}

        ////public Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.DialogResult ShowErrorMessage(string message)
        ////{
        ////    return Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.DialogResult.OK;
        ////    ////return UserMessage.ShowErrorMessage(message);
        ////}

        ////public virtual void UpdateObserver(object value) { return; }

        ////public virtual void UpdateObserver(object value, string message) { return; }

        ////public IObservable GetObservable()
        ////{
        ////    return ObservableDetail;
        ////}

        ////public virtual void AddObserver(IObserver observer)
        ////{
        ////    GetObservable().AddObserver(observer);
        ////}

        ////public bool RemoveObserver(IObserver observer)
        ////{
        ////    return GetObservable().RemoveObserver(observer);
        ////}

        ////public void NotifyObserver(object value)
        ////{
        ////    GetObservable().NotifyObserver(value);
        ////}

        ////public void NotifyObserver(object value, string message)
        ////{
        ////    GetObservable().NotifyObserver(value, message);
        ////}

        ////private void SetInitialViewState()
        ////{
        ////    ////InitializeComponent();
        ////}

        ////#endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_mvp.views
{
    internal interface IPayModeView
    {
        string payModeId { get; set; }
        string payModeName { get; set; }
        string payModeObservation {  get; set; }
        string Searchvalue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler CancelEvent;
        void SetPayModeListBildingSource(BindingSource PayModelList);
        void Show();

 }
}

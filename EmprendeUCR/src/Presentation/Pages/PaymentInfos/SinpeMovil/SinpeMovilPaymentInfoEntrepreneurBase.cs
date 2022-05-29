using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using System.Collections.Generic;
using System;

namespace EmprendeUCR.Presentation.Pages.PaymentInfos
{
    public class SinpeMovilPaymentInfoEntrepreneurBase : ComponentBase
    {
        protected string AddButtonTitle = "Agregar";
        protected const string SINPE_MOVIL = "SINPE Movil";
        protected SfGrid<SinpeMovilPaymentInfo> SinpeMovilPaymentInfoGrid;
        protected IEnumerable<SinpeMovilPaymentInfo> _sinpeMovilPaymentInfoList;
        protected List<ItemModel> SinpeMovilToolbarItems = new List<ItemModel>();
        protected bool AddSinpePhoneNumberDialogVisible = false;
        protected string AddedNumber = "";
        public void SinpeMovilCommandClicked(CommandClickEventArgs<SinpeMovilPaymentInfo> args)
        {
            if (args.CommandColumn.Title == "Editar")
            {
            }
            else if (args.CommandColumn.Title == "Eliminar")
            {
            }
        }
        protected void SinpeMovilToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (args.Item.Text == AddButtonTitle)
            {
                ShowAddSinpePhoneNumberDialog();
            }
        }
        protected void ShowAddSinpePhoneNumberDialog()
        {
            AddSinpePhoneNumberDialogVisible = true;
        }
        protected void CloseAddSinpePhoneNumberDialog()
        {
            AddedNumber = "";
            AddSinpePhoneNumberDialogVisible = false;
        }
    }
}
